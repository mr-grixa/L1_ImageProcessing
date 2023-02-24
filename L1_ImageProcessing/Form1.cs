using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L1_ImageProcessing
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                streamReader = new StreamReader(openFileDialog.FileName);
                
            }
        }
        
        public void Load()
        {
            
        }
        int [] data;
        private void button2_Click(object sender, EventArgs e)
        {
            string[] valuses = streamReader.ReadLine().Split(' ');
            data=new int[valuses.Length-1];
            for (int i = 1; i < valuses.Length; i++)
            {
                data[i]=int.Parse(valuses[i]);
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(valuses);
        }
    }
}
