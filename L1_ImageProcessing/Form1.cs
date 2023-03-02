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
using System.Text.RegularExpressions;

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
            Draw();
        }

        private void Draw()
        {
            string[] valuses = streamReader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            data = new int[valuses.Length - 1];
            for (int i = 1; i < valuses.Length; i++)
            {
                data[i - 1] = int.Parse(valuses[i]);
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(valuses);
            double size = 0.1;
            Bitmap bitmap = new Bitmap(400, 400);
            double F = 0;
            foreach (int i in data)
            {
                F += Math.PI / 512;
                double X = Math.Cos(F) * i;
                double Y = Math.Sin(F) * i;
                X = X * size + 200;
                Y = Y * size + 200;
                if (X < 400 && X > 0 && Y < 400 && Y > 0)
                {
                    bitmap.SetPixel((int)(X), (int)(Y), Color.Blue);
                }

            }
            pictureBoxMain.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button_start.Text = "Старт";
            }
            else
            {
                timer1.Enabled = true;
                button_start.Text = "Стоп";
            }
        }
    }
}
