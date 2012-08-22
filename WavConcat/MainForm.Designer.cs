namespace WavConcat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildWavConcatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWavConcatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBPS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.comboBoxBPS = new System.Windows.Forms.ComboBox();
            this.comboBoxSR = new System.Windows.Forms.ComboBox();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.labelBPS = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.labelCN = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.contextMenuListView.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(748, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildWavConcatToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildWavConcatToolStripMenuItem
            // 
            this.buildWavConcatToolStripMenuItem.Name = "buildWavConcatToolStripMenuItem";
            this.buildWavConcatToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.buildWavConcatToolStripMenuItem.Text = "Build WavConcat";
            this.buildWavConcatToolStripMenuItem.Click += new System.EventHandler(this.buildWavConcatToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWavConcatToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutWavConcatToolStripMenuItem
            // 
            this.aboutWavConcatToolStripMenuItem.Name = "aboutWavConcatToolStripMenuItem";
            this.aboutWavConcatToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutWavConcatToolStripMenuItem.Text = "About WavConcat";
            this.aboutWavConcatToolStripMenuItem.Click += new System.EventHandler(this.aboutWavConcatToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Wav files (*.wav)|*.wav";
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Open Wav files";
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCN,
            this.columnHeaderSR,
            this.columnHeaderBPS});
            this.listView.ContextMenuStrip = this.contextMenuListView;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(13, 39);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(481, 248);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 152;
            // 
            // columnHeaderCN
            // 
            this.columnHeaderCN.Text = "Channels Number";
            this.columnHeaderCN.Width = 100;
            // 
            // columnHeaderSR
            // 
            this.columnHeaderSR.Text = "Sample Rate";
            this.columnHeaderSR.Width = 75;
            // 
            // columnHeaderBPS
            // 
            this.columnHeaderBPS.Text = "Bits Per Sample";
            this.columnHeaderBPS.Width = 87;
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuListView.Name = "contextMenuListView";
            this.contextMenuListView.Size = new System.Drawing.Size(108, 26);
            this.contextMenuListView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuListView_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Wav files (*.wav)|*.wav";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.Title = "Save File As";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.comboBoxBPS);
            this.groupBoxFilter.Controls.Add(this.comboBoxSR);
            this.groupBoxFilter.Controls.Add(this.comboBoxCN);
            this.groupBoxFilter.Controls.Add(this.labelBPS);
            this.groupBoxFilter.Controls.Add(this.labelSR);
            this.groupBoxFilter.Controls.Add(this.labelCN);
            this.groupBoxFilter.Location = new System.Drawing.Point(500, 39);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(236, 106);
            this.groupBoxFilter.TabIndex = 2;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter Options";
            // 
            // comboBoxBPS
            // 
            this.comboBoxBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBPS.FormattingEnabled = true;
            this.comboBoxBPS.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32"});
            this.comboBoxBPS.Location = new System.Drawing.Point(111, 73);
            this.comboBoxBPS.Name = "comboBoxBPS";
            this.comboBoxBPS.Size = new System.Drawing.Size(119, 21);
            this.comboBoxBPS.TabIndex = 5;
            this.comboBoxBPS.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBPS_SelectionChangeCommitted);
            // 
            // comboBoxSR
            // 
            this.comboBoxSR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSR.FormattingEnabled = true;
            this.comboBoxSR.Items.AddRange(new object[] {
            "8000",
            "11025",
            "16000",
            "22050",
            "32000",
            "44100",
            "48000",
            "96000",
            "192000"});
            this.comboBoxSR.Location = new System.Drawing.Point(111, 46);
            this.comboBoxSR.MaxDropDownItems = 9;
            this.comboBoxSR.Name = "comboBoxSR";
            this.comboBoxSR.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSR.TabIndex = 4;
            this.comboBoxSR.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSR_SelectionChangeCommitted);
            // 
            // comboBoxCN
            // 
            this.comboBoxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxCN.Location = new System.Drawing.Point(111, 19);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(119, 21);
            this.comboBoxCN.TabIndex = 3;
            this.comboBoxCN.Tag = "";
            this.comboBoxCN.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCN_SelectionChangeCommitted);
            // 
            // labelBPS
            // 
            this.labelBPS.AutoSize = true;
            this.labelBPS.Location = new System.Drawing.Point(6, 76);
            this.labelBPS.Name = "labelBPS";
            this.labelBPS.Size = new System.Drawing.Size(79, 13);
            this.labelBPS.TabIndex = 2;
            this.labelBPS.Text = "Bit Per Sample:";
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(6, 49);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(71, 13);
            this.labelSR.TabIndex = 1;
            this.labelSR.Text = "Sample Rate:";
            // 
            // labelCN
            // 
            this.labelCN.AutoSize = true;
            this.labelCN.Location = new System.Drawing.Point(6, 22);
            this.labelCN.Name = "labelCN";
            this.labelCN.Size = new System.Drawing.Size(94, 13);
            this.labelCN.TabIndex = 0;
            this.labelCN.Text = "Channels Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 299);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WavConcat";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuListView.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWavConcatToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSR;
        private System.Windows.Forms.ColumnHeader columnHeaderCN;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildWavConcatToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ColumnHeader columnHeaderBPS;
        private System.Windows.Forms.ComboBox comboBoxBPS;
        private System.Windows.Forms.ComboBox comboBoxSR;
        private System.Windows.Forms.ComboBox comboBoxCN;
        private System.Windows.Forms.Label labelBPS;
        private System.Windows.Forms.Label labelSR;
        private System.Windows.Forms.Label labelCN;
    }
}

