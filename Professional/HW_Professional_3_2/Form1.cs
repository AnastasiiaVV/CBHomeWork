using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace HW_Professional_3_2
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

        string file;
        private void button1_Click(object sender, EventArgs e) {
            if (SearchFile(@"C:\Training", textBox1.Text)) {
                textBox2.Text = "Файл " + file + " найден!";
            } else {
                textBox2.Text = "Файл " + file + "не найден!";
            }

		}

        bool SearchFile(string directory, string fileName) {
            DirectoryInfo dir = new DirectoryInfo(directory);

            if (!dir.Exists) {
                return false;
            }

            FileInfo[] fileInfo = null;
            try {
                fileInfo = dir.GetFiles(fileName);
            } catch (Exception) {
                return false;
            }

            if (fileInfo.Length == 0) {
                DirectoryInfo[] dirInfo = dir.GetDirectories();

                if (dirInfo.Length == 0) {
                    return false;
                }

                foreach (var item in dirInfo) {
                    if (item.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory)) {
                        continue;
                    }

                    if (SearchFile(item.FullName, fileName)) {
                        return true;
                    }
                }
                return false;
            } else {
                file = fileInfo[0].FullName;
                return true;
            }

        }

		private void button2_Click(object sender, EventArgs e) {
            StreamReader reader = new StreamReader(file);
            textBox2.Text = reader.ReadToEnd();
            reader.Close();
            
        }

		private void button3_Click(object sender, EventArgs e) {
            FileStream source = File.OpenRead(file);
            FileStream destination = File.Create(@"C:\Training\archive.zip");
            GZipStream compression = new GZipStream(destination, CompressionMode.Compress);

            int theByte = source.ReadByte();
            while (theByte != -1) {
                compression.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compression.Close();
		}
	}
}
