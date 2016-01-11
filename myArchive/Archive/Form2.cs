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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string zipPath;
        string file;
        public void Choose_file_click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fn = Path.GetFileNameWithoutExtension(openFileDialog2.FileName);
                string tp = Path.GetExtension(openFileDialog2.FileName);
                file = Path.Combine(fn+tp);
                textBox1.Text = file;

            }
           
        }
        public void Choose_archive_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                zipPath = openFileDialog1.FileName;
                add_to_archive();
            }
            
        }

        public void add_to_archive()
        {

            using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry(file);

                }
            }
            prBar f4 = new prBar();
            f4.Show();
        }

        private void Ok_click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

       

       
    }
}
