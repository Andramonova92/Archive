using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Archive
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string zipPath;
       
        Form1 f1 = new Form1();
        private void unzip1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                zipPath = openFileDialog1.FileName;

            }
        }

        private void unzip2_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFiledialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                unzip();
            }
          
        }

        private void unzip()
        {
            string fn = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
            string dr = Path.GetDirectoryName(saveFileDialog1.FileName);
            string tp = Path.GetExtension(saveFileDialog1.FileName);
            string extractPath = Path.Combine(dr, fn + tp);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            prBar f4 = new prBar();
            f4.Show();
        }

        private void OK_click(object sender, EventArgs e)
        {
           
            this.Close();
            f1.Show();
        }
    }
}
