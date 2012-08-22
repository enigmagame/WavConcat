using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WavConcat
{
    class WaveSound
    {
        public string Name { get; set; }

        // RIFF Chunk
        public int ChunkID { get; set; }
        public int ChunkSize { get; set; }
        public int Format { get; set; }

        // Format Chunk
        public int Subchunk1ID { get; set; }
        public int Subchunk1Size { get; set; }
        public short AudioFormat { get; set; }
        public short NumChannels { get; set; }
        public int SampleRate { get; set; }
        public int ByteRate { get; set; }
        public short BlockAlign { get; set; }
        public short BitsPerSample { get; set; }

        // Data Chunk
        public int Subchunk2ID { get; set; }
        public int Subchunk2Size { get; set; }
        public byte[] Data { get; set; }

        public WaveSound()
        {
            Name = "";
            ChunkID = 0;
            ChunkSize = 0;
            Format = 0;
            Subchunk1ID = 0;
            Subchunk1Size = 0;
            AudioFormat = 0;
            NumChannels = 0;
            SampleRate = 0;
            ByteRate = 0;
            BlockAlign = 0;
            BitsPerSample = 0;
            Subchunk2ID = 0;
            Subchunk2Size = 0;
            Data = null;
        }

        public void Read(String FileName)
        {
            FileStream stream = new FileStream(FileName, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);

            ChunkID = reader.ReadInt32();
            ChunkSize = reader.ReadInt32();
            Format = reader.ReadInt32();
            Subchunk1ID = reader.ReadInt32();
            Subchunk1Size = reader.ReadInt32();
            AudioFormat = reader.ReadInt16();
            NumChannels = reader.ReadInt16();
            SampleRate = reader.ReadInt32();
            ByteRate = reader.ReadInt32();
            BlockAlign = reader.ReadInt16();
            BitsPerSample = reader.ReadInt16();
            Subchunk2ID = reader.ReadInt32();
            Subchunk2Size = reader.ReadInt32();
            Data = reader.ReadBytes(Subchunk2Size);

            reader.Close();
            stream.Close();
        }

        public void Write(String fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            FileStream stream = new FileStream(fileName, FileMode.CreateNew);
            BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(ChunkID);
            writer.Write(ChunkSize);
            writer.Write(Format);
            writer.Write(Subchunk1ID);
            writer.Write(Subchunk1Size);
            writer.Write(AudioFormat);
            writer.Write(NumChannels);
            writer.Write(SampleRate);
            writer.Write(ByteRate);
            writer.Write(BlockAlign);
            writer.Write(BitsPerSample);
            writer.Write(Subchunk2ID);
            writer.Write(Subchunk2Size);
            writer.Write(Data);

            writer.Close();
            stream.Close();
        }
    }
}
