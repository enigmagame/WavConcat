using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WavConcat
{
    public partial class MainForm : Form
    {
        private const int DEFAULT_CN = 1;
        private const int DEFAULT_SR = 5;
        private const int DEFAULT_BPS = 1;

        public MainForm()
        {
            InitializeComponent();
            comboBoxCN.SelectedIndex = DEFAULT_CN;
            comboBoxSR.SelectedIndex = DEFAULT_SR;
            comboBoxBPS.SelectedIndex = DEFAULT_BPS;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in openFileDialog.FileNames)
                {
                    AddFile(fileName);
                }

                FilterOptionsChange();
            }
        }

        private void aboutWavConcatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void buildWavConcatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                List<WaveSound> waveList = new List<WaveSound>();
                
                var exportableWavSound =
                    from ListViewItem item in listView.Items
                    where item.BackColor == Color.LimeGreen
                    select item;

                foreach (ListViewItem item in exportableWavSound)
                {
                    waveList.Add((WaveSound)item.Tag);
                }

                if (waveList.Count > 0)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        BuildWavConcat(saveFileDialog.FileName, ref waveList);
                    }
                }
                else
                {
                    MessageBox.Show("No compatible file is selected.", "Build WavConcat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You must select wav files first.", "Build WavConcat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string fileName in fileNames)
                {
                    if (string.Compare(Path.GetExtension(fileName), ".wav", true) == 0)
                    {
                        AddFile(fileName);
                    }
                }

                FilterOptionsChange();
            }
        }

        private void contextMenuListView_Opening(object sender, CancelEventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void AddFile(string fullFilePath)
        {
            WaveSound sound = new WaveSound();
            sound.Name = Path.GetFileNameWithoutExtension(fullFilePath);
            sound.Read(fullFilePath);
 
            ListViewItem item = new ListViewItem(sound.Name);
            item.SubItems.Add(sound.NumChannels.ToString());
            item.SubItems.Add(sound.SampleRate.ToString());
            item.SubItems.Add(sound.BitsPerSample.ToString());
            item.Tag = sound;
            listView.Items.Add(item);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] selectedIndices = new int[listView.SelectedIndices.Count];
            listView.SelectedIndices.CopyTo(selectedIndices, 0);

            DeleteItems(ref selectedIndices);
        }

        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int[] selectedIndices = new int[listView.SelectedIndices.Count];
                listView.SelectedIndices.CopyTo(selectedIndices, 0);

                DeleteItems(ref selectedIndices);
            }
        }

        private void comboBoxCN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterOptionsChange();
        }

        private void comboBoxSR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterOptionsChange();
        }

        private void comboBoxBPS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterOptionsChange();
        }

        private void FilterOptionsChange()
        {
            string selectedCN = (string)comboBoxCN.SelectedItem;
            string selectedSR = (string)comboBoxSR.SelectedItem;
            string selectedBPS = (string)comboBoxBPS.SelectedItem;

            foreach (ListViewItem item in listView.Items)
            {
                if ((item.SubItems[1].Text == selectedCN) && (item.SubItems[2].Text == selectedSR) && (item.SubItems[3].Text == selectedBPS))
                {
                    item.BackColor = Color.LimeGreen;
                }
                else
                {
                    item.BackColor = Color.Red;
                }
            }
        }

        private void BuildWavConcat(string fileName, ref List<WaveSound> waveList)
        {
            WaveSound outputSound = new WaveSound();
            WavConcat wavConcatInfo = new WavConcat();
            FileInfo fileInfo = new FileInfo(fileName);

            outputSound.Name = fileInfo.FullName;
            wavConcatInfo.Name = Path.GetFileNameWithoutExtension(fileInfo.Name);
            outputSound.ChunkID = waveList[0].ChunkID;
            outputSound.ChunkSize = waveList[0].ChunkSize;
            outputSound.Format = waveList[0].Format;
            outputSound.Subchunk1ID = waveList[0].Subchunk1ID;
            outputSound.Subchunk1Size = waveList[0].Subchunk1Size;
            outputSound.AudioFormat = waveList[0].AudioFormat;
            outputSound.NumChannels = waveList[0].NumChannels;
            outputSound.SampleRate = waveList[0].SampleRate;
            outputSound.ByteRate = waveList[0].ByteRate;
            outputSound.BlockAlign = waveList[0].BlockAlign;
            outputSound.BitsPerSample = waveList[0].BitsPerSample;
            outputSound.Subchunk2ID = waveList[0].Subchunk2ID;

            foreach (WaveSound sound in waveList)
            {
                outputSound.Subchunk2Size += sound.Subchunk2Size;
            }

            outputSound.Data = new byte[outputSound.Subchunk2Size];

            int waveSize = 0;
            foreach (WaveSound sound in waveList)
            {
                WavConcat.Effect effect = new WavConcat.Effect();
                effect.Name = sound.Name;
                effect.Start = waveSize;
                Buffer.BlockCopy(sound.Data, 0, outputSound.Data, waveSize, sound.Subchunk2Size);
                waveSize += sound.Subchunk2Size;
                effect.End = (waveSize - 1);

                wavConcatInfo.EffectList.Add(effect);
            }

            outputSound.Write(fileName);

            XmlSerializer serializer = new XmlSerializer(typeof(WavConcat));
            string xmlFileName = Path.ChangeExtension(fileName, ".xml");
            TextWriter writer = new StreamWriter(xmlFileName, false);

            serializer.Serialize(writer, wavConcatInfo);
            writer.Close();
        }

        private void DeleteItems(ref int[] selectedIndices)
        {
            Array.Reverse(selectedIndices);

            foreach (int index in selectedIndices)
            {
                listView.Items[index].Remove();
            }
        }
    }
}
