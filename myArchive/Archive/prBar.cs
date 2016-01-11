using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Archive
{
    public partial class prBar : Form
    {
        public prBar()
        {
            InitializeComponent();
            
        }
       
       
        private void prBar_Load(object sender, EventArgs e)
        {
           var row = 100;
            progressBar1.Maximum = row;
            for (int i = 1; i <= row; i++)
            {
                progressBar1.Value = i;
                label1.Text = "Выполнение" + i.ToString() + "%";
                //Thread newThread = new Thread(Form1.create_archive);
              //  newThread.Start();
            }        
       
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
