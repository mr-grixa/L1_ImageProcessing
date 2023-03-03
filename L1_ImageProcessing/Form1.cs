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
            GenerateXY();
        }
        List<List<PointF>> klasters;
        private void GenerateXY()
        {
            string[] valuses = streamReader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            data = new int[valuses.Length - 1];
            for (int i = 1; i < valuses.Length; i++)
            {
                data[i - 1] = int.Parse(valuses[i]);
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(valuses);

            double F = 0;
            List<PointF> points = new List<PointF>();
            foreach (int i in data)
            {
                F += Math.PI / 512;
                double X = Math.Cos(F) * i;
                double Y = Math.Sin(F) * i;
                points.Add(new PointF((float)X, (float)Y));

            }
            klasters = KMeans(points, (int)numericUpDownKlaster.Value);
            Draw();

            
        }
        public void Draw()
        {
            Bitmap bitmap = new Bitmap(400, 400);
            Random random = new Random();
            double size = (double)numericUpDownSize.Value;
            foreach (List<PointF> klaster in klasters)
            {
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                foreach(PointF point in klaster)
                {
                    double X = point.X * size + 200;
                    double Y  = point.Y * size + 200;
                    if (X < 400 && X > 0 && Y < 400 && Y > 0)
                    {
                        bitmap.SetPixel((int)(X), (int)(Y), Color.Blue);
                    }
                }
            }
            pictureBoxMain.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenerateXY();
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

        public static List<List<PointF>> KMeans(List<PointF> points, int k)
        {
            List<List<PointF>> clusters = new List<List<PointF>>();

            // Step 1: Initialize k clusters randomly
            List<PointF> centroids = InitializeClusters(points, k);

            while (true)
            {
                // Step 2: Assign each point to the nearest centroid
                clusters.Clear();
                for (int i = 0; i < k; i++)
                {
                    clusters.Add(new List<PointF>());
                }
                foreach (PointF point in points)
                {
                    int nearestCentroidIndex = GetNearestCentroidIndex(point, centroids);
                    clusters[nearestCentroidIndex].Add(point);
                }

                // Step 3: Recalculate centroids
                List<PointF> newCentroids = new List<PointF>();
                for (int i = 0; i < k; i++)
                {
                    if (clusters[i].Count == 0)
                    {
                        newCentroids.Add(centroids[i]);
                    }
                    else
                    {
                        PointF newCentroid = new PointF(
                            clusters[i].Average(p => p.X),
                            clusters[i].Average(p => p.Y)
                        );
                        newCentroids.Add(newCentroid);
                    }
                }

                // Step 4: Check for convergence
                bool converged = true;
                for (int i = 0; i < k; i++)
                {
                    if (centroids[i] != newCentroids[i])
                    {
                        converged = false;
                        break;
                    }
                }
                if (converged)
                {
                    break;
                }

                centroids = newCentroids;
            }

            return clusters;
        }

        private static List<PointF> InitializeClusters(List<PointF> points, int k)
        {
            List<PointF> centroids = new List<PointF>();
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                int randomIndex = random.Next(points.Count);
                centroids.Add(points[randomIndex]);
            }
            return centroids;
        }

        private static int GetNearestCentroidIndex(PointF point, List<PointF> centroids)
        {
            double minDistance = double.MaxValue;
            int nearestCentroidIndex = 0;
            for (int i = 0; i < centroids.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - centroids[i].X, 2) + Math.Pow(point.Y - centroids[i].Y, 2));
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestCentroidIndex = i;
                }
            }
            return nearestCentroidIndex;
        }

    }
}
