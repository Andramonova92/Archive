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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       
       

         public void Create_Archive_Click(object sender, EventArgs e)
         {
             create_archive();
             prBar f4 = new prBar();
             f4.Show();
         }

         public static void create_archive()
         {
             FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
             if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
             {
                 string startPath = folderBrowserDialog1.SelectedPath;
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                 saveFileDialog1.Filter = "zip files (*.zip)|*.zip|rar files (*.rar)|*.rar";
                 saveFileDialog1.FilterIndex = 2;
                 saveFileDialog1.RestoreDirectory = true;


                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     string fn = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                     string dr = Path.GetDirectoryName(saveFileDialog1.FileName);
                     string tp = Path.GetExtension(saveFileDialog1.FileName);
                     string zipPath = Path.Combine(dr, fn + tp);

                     ZipFile.CreateFromDirectory(startPath, zipPath);

                 }
             }
         }

        

        

         
   

         private void add_in_archive_Click(object sender, EventArgs e)
         {
             this.Hide();
             Form2 f2 = new Form2();
             f2.Show();
         }

         private void Unzip_Click(object sender, EventArgs e)
         {
             this.Hide();
             Form3 f3 = new Form3();
             f3.Show();
         }

         private void Close_Click(object sender, EventArgs e)
         {
             this.Close();
            
         }

         

    }
}
