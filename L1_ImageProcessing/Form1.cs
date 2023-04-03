using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static L1_ImageProcessing.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace L1_ImageProcessing
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;
        List<PointF> points = new List<PointF>();
        Thread t;
        byte[] bytes;
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
                textBox_path.Text = openFileDialog.FileName;
            }
        }

        public void Load()
        {

        }
        int[] data;
        private void button_next_Click(object sender, EventArgs e)
        {            
            GenerateXY();
        }
        
        private void GenerateXY()
        {
            bool streamReaderTest = true;
            if (streamReader == null)
            {
                try
                {
                    streamReader = new StreamReader(textBox_path.Text);
                }
                catch { streamReaderTest = false; }
            }
            if (streamReaderTest&&!streamReader.EndOfStream)
            {
                string[] valuses = streamReader.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                data = new int[valuses.Length - 1];
                for (int i = 1; i < valuses.Length; i++)
                {
                    data[i - 1] = int.Parse(valuses[i]);
                }
                listBox1.Items.Clear();
                listBox1.Items.AddRange(valuses);

                double F = 0;
                points = new List<PointF>();
                foreach (int i in data)
                {
                    F += Math.PI / 512;
                    double X = Math.Cos(F) * i;
                    double Y = Math.Sin(F) * i;
                    points.Add(new PointF((float)X, (float)Y));

                }
                //Cluster[] clusters;
                //if (clusters != null)
                //{
                //    Cluster[] clustersOld = clusters;
                //    clusters = KMeans(points, (int)numericUpDownKlaster.Value);
                //    Search(clustersOld);
                //}
                //else
                //{
                Draw();
            }

        }
        public void Draw()
        {
            if (checkBox_claster.Checked&&points.Count>0)
            {
                Cluster[] clusters = KMeans(points, (int)numericUpDownKlaster.Value);
                DrawClusters(clusters);
            }
            else
            {
                DrawDot(points);
            }
        }
        public void DrawDot(List<PointF> points)
        {
            Bitmap bitmap = new Bitmap(400, 400);
            Random random = new Random();
            double size = (double)numericUpDownSize.Value;

            foreach (PointF point in points)
            {
                double X = point.X * size + 200;
                double Y = point.Y * size + 200;
                if (X < 400 && X > 0 && Y < 400 && Y > 0)
                {
                    bitmap.SetPixel((int)(X), (int)(Y), Color.White);
                }
            }
            pictureBoxMain.Image = bitmap;
        }

        public void DrawClusters(Cluster[] clusters)
        {
            Bitmap bitmap = new Bitmap(400, 400);
            Random random = new Random();
            double size = (double)numericUpDownSize.Value;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            foreach (Cluster cluster in clusters)
            {
                if (cluster.Points.Count != 0)
                {

                    Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    double sumX = 0;
                    double sumY = 0;
                    double sumXY = 0;
                    double sumX2 = 0;
                    foreach (PointF point in cluster.Points)
                    {
                        double X = point.X * size + 200;
                        double Y = point.Y * size + 200;
                        if (X < 400 && X > 0 && Y < 400 && Y > 0)
                        {
                            bitmap.SetPixel((int)(X), (int)(Y), color);
                        }
                        sumX += point.X;
                        sumY += point.Y;
                        sumXY += point.X * point.Y;
                        sumX2 += point.X * point.X;
                    }

                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.DrawString(cluster.Id.ToString(), this.Font,
                            new SolidBrush(color), (int)(cluster.Center.X * size + 200), (int)(cluster.Center.Y * size + 200), sf);
                        //double N = cluster.Points.Count();
                        //double k = ((N * XYsum) - (Xsum * Ysum))
                        //        / ((N * XXsum) - (Xsum * Xsum));
                        //double b = (Ysum - (k * Xsum)) / N;
                        double n = cluster.Points.Count();

                        double k = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
                        double b = (sumY - k * sumX) / n;

                        double centerX = (int)cluster.Center.X;
                        double centerY = (int)cluster.Center.Y;
                        double radius = (double)numericUpDown_R.Value;
                        double x1 = cluster.Center.X - radius;
                        double y1 = k * x1 + b;
                        double x2 = cluster.Center.X + radius;
                        double y2 = k * x2 + b;

                        if (y1 < centerY - radius)
                        {
                            x1 = (centerY - radius - b) / k;
                            y1 = centerY - radius;
                        }
                        else if (y1 > centerY + radius)
                        {
                            x1 = (centerY + radius - b) / k;
                            y1 = centerY + radius;
                        }

                        if (y2 < centerY - radius)
                        {
                            x2 = (centerY - radius - b) / k;
                            y2 = centerY - radius;
                        }
                        else if (y2 > centerY + radius)
                        {
                            x2 = (centerY + radius - b) / k;
                            y2 = centerY + radius;
                        }

                        if (x1 < centerX - radius)
                        {
                            y1 = k * (centerX - radius) + b;
                            x1 = centerX - radius;
                        }
                        else if (x1 > centerX + radius)
                        {
                            y1 = k * (centerX + radius) + b;
                            x1 = centerX + radius;
                        }

                        if (x2 < centerX - radius)
                        {
                            y2 = k * (centerX - radius) + b;
                            x2 = centerX - radius;
                        }
                        else if (x2 > centerX + radius)
                        {
                            y2 = k * (centerX + radius) + b;
                            x2 = centerX + radius;
                        }
                        try
                        {
                            graphics.DrawEllipse(Pens.Black,
                                (int)((cluster.Center.X - radius) * size + 200),
                                (int)((cluster.Center.Y - radius) * size + 200),
                                (int)(radius * 2 * size),
                                (int)(radius * 2 * size));
                            graphics.DrawLine(Pens.Red, (int)(x1 * size + 200),
                                                        (int)(y1 * size + 200),
                                                        (int)(x2 * size + 200),
                                                        (int)(y2 * size + 200));
                        }
                        catch { }
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

        //private void Search(Cluster[] clustersOld)
        //{
        //    double mindistant = (double)numericUpDown_R.Value;
        //    foreach (Cluster cluster1 in clusters)
        //    {
        //        Cluster cluster = null;
        //        double distant = mindistant;
        //        foreach (Cluster cluster2 in clustersOld)
        //        {
        //            double dx = cluster1.Center.X - cluster2.Center.X;
        //            double dy = cluster1.Center.Y - cluster2.Center.Y;
        //            double _distant = Math.Sqrt(dy * dy + dx * dx);
        //            if (distant > _distant)
        //            {
        //                distant = _distant;
        //                cluster = cluster2;
        //            }
        //        }
        //        if (cluster != null)
        //        {
        //            cluster1.Id = cluster.Id;
        //        }
        //        else
        //        {
        //            cluster1.Id = 0;
        //        }
        //    }
        //}

        public class Cluster
        {
            public int Id;// Идентификатор кластера
            public List<PointF> Points; // Список точек кластера
            public PointF Center; // Центр кластера

            public Cluster(int id, List<PointF> points, PointF center)
            {
                Id = id;
                Points = points;
                Center = center;
            }
        }

        public Cluster[] KMeans(List<PointF> points, int k)
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
            Cluster[] cluster = new Cluster[k];
            for (int i = 0; i < clusters.Count; i++)
            {
                cluster[i] = new Cluster(i, clusters[i], centroids[i]);
            }
            return cluster;
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

        private int GetNearestCentroidIndex(PointF point, List<PointF> centroids)
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

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            Cluster[] clusters = KMeans(points, (int)numericUpDownKlaster.Value);
            DrawClusters(clusters);
        }


        public delegate void AddItemDelegate(byte[] bytes);
        public void AddItem(byte[] bytes)
        {
            string sByte = "";
            foreach (byte b in bytes)
            {
                sByte += b.ToString() + " ";
            }
            points = new List<PointF>();
            double F = 0;
            int[] data = new int[bytes.Length / 2];
            for (int i = 0; i < bytes.Length / 2; i++)
            {
                data[i] = bytes[2 * i] * 255 + bytes[2 * i + 1];
            }
            foreach (int i in data)
            {

                F += Math.PI / 722 * 4;
                double X = Math.Cos(F) * i;
                double Y = Math.Sin(F) * i;
                points.Add(new PointF((float)X, (float)Y));

            }
            //richTextBox1.Text = sByte;
            listBox1.Items.Add(sByte);
        }

        private void button_IP_lidar_Click(object sender, EventArgs e)
        {

            if (t == null)
            {
                t = new Thread(new ThreadStart(StartListener));
                t.Start();
                button_IP_lidar.Text = "Отключится";
                timer2.Start();
            }
            else
            {
                if (t.ThreadState == ThreadState.Running)
                {
                    button_IP_lidar.Text = "Подключится";
                    t.Suspend();
                    timer2.Stop();
                }
                else
                {
                    button_IP_lidar.Text = "Отключится";
                    t.Resume();
                    timer2.Start();
                }
            }


        }

        private void StartListener()
        {
            int listenPort = int.Parse(textBox_Port.Text);
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (true)
                {

                    //listBox1.Items.Add("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    //listBox1.Items.Add($"Received broadcast from {groupEP} :");
                    //listBox1.Items.Add($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");

                    listBox1.Invoke(new AddItemDelegate(AddItem), new object[] { bytes });
                }
            }
            catch (SocketException e)
            {
                //listBox1.Invoke(new AddItemDelegate(AddItem), new object[] { e });
            }
            finally
            {
                listener.Close();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t!=null)
            {
            if (t.ThreadState == ThreadState.Suspended)
            {
                t.Resume();            
            }
            t.Abort();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
