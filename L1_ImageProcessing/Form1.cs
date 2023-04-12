using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using static L1_ImageProcessing.Form1;
using static System.Windows.Forms.LinkLabel;

namespace L1_ImageProcessing
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;
        List<PointF> points = new List<PointF>();
        List<Line> lines = new List<Line>();
        public List<Line> linesOld = new List<Line>();
        Thread t;
        byte[] bytes;
        public Form1()
        {
            InitializeComponent();
            linesOld.Add(new Line(new PointF(0,0), new PointF(0, 0), 0));
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
            if (streamReaderTest && !streamReader.EndOfStream)
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
                Draw();
            }
        }

        public void Draw()
        {
            if (points.Count > 0)
            {
                Bitmap bitmap = new Bitmap(400, 400);
                Cluster[] clusters = KMeans(points, (int)numericUpDownKlaster.Value);
                if (checkBox_claster.Checked)
                    bitmap = DrawClusters(clusters, bitmap);
                else
                    bitmap =DrawDot(points, bitmap);
                if (checkBox_DrawRadius.Checked)
                    bitmap=DrawRadius(clusters, bitmap);
                if (checkBox_wall.Checked)
                    bitmap =DrawData(clusters, bitmap);
                pictureBoxMain.Image = bitmap;
            }

        }
        public Bitmap DrawDot(List<PointF> points, Bitmap bitmap)
        {
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
            return bitmap;
        }

        public Bitmap DrawData(Cluster[] clusters, Bitmap bitmap)
        {

            Random random = new Random(10);
            double size = (double)numericUpDownSize.Value;
            CalculateClusterLine(clusters);
            SearchWall(clusters);


                LineMatching matching = new LineMatching();
                linesOld = matching.MatchLines(lines, linesOld);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                //listBox1.Items.Clear();
                foreach (Line line in linesOld)
                {
                    Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    Pen pen = new Pen(color);
                    pen.Width = 5;
                    graphics.DrawLine(pen, (int)(line.firstPoint.X * size + 200),
                                                 (int)(line.firstPoint.Y * size + 200),
                                                 (int)(line.lastPoint.X * size + 200),
                                                 (int)(line.lastPoint.Y * size + 200));

                    string text = line.lineId.ToString();
                    graphics.DrawString(text, this.Font,
                        Brushes.Red, (int)(((line.firstPoint.X + line.lastPoint.X) / 2) * size + 200), (int)(((line.firstPoint.Y + line.lastPoint.Y) / 2) * size + 200), sf);
                }
            }
            for (int i = 0; i < linesOld.Count; i++)
            {
                listBox1.Items.Add(linesOld[i].lineId.ToString());
                
            }
            return bitmap;
        }


        public Bitmap DrawClusters(Cluster[] clusters, Bitmap bitmap)
        {
            Random random = new Random(10);
            double size = (double)numericUpDownSize.Value;
            foreach (Cluster cluster in clusters)
            {
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                if (cluster.Points.Count != 0)
                {
                    foreach (PointF point in cluster.Points)
                    {
                        double X = point.X * size + 200;
                        double Y = point.Y * size + 200;
                        if (X < 400 && X > 0 && Y < 400 && Y > 0)
                        {
                            bitmap.SetPixel((int)(X), (int)(Y), color);                          
                        }    
                    }
                }
            }

            return bitmap;
        }

        public Bitmap DrawRadius(Cluster[] clusters, Bitmap bitmap)
        {
            double size = (double)numericUpDownSize.Value;
            Random random = new Random(10);
            Color[] colors = new Color[clusters.Length];
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            CalculateClusterLine(clusters);
            foreach (Cluster cluster in clusters)
            {
                if (cluster.Points.Count != 0)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        
                        string text = cluster.Points.Count.ToString();
                        graphics.DrawString(text, this.Font,
                             new SolidBrush(colors[cluster.wallId]), (int)(cluster.Center.X * size + 200), (int)(cluster.Center.Y * size + 200), sf);


                            double centerX = cluster.Center.X;
                            double centerY = cluster.Center.Y;
                            double radius = (double)numericUpDown_R.Value;
                            double x1 = cluster.Center.X - radius;
                            double y1 = cluster.k * x1 + cluster.b;
                            double x2 = cluster.Center.X + radius;
                            double y2 = cluster.k * x2 + cluster.b;

                            #region Проверка радиуса
                            if (y1 < centerY - radius)
                            {
                                x1 = (centerY - radius - cluster.b) / cluster.k;
                                y1 = centerY - radius;
                            }
                            else if (y1 > centerY + radius)
                            {
                                x1 = (centerY + radius - cluster.b) / cluster.k;
                                y1 = centerY + radius;
                            }

                            if (y2 < centerY - radius)
                            {
                                x2 = (centerY - radius - cluster.b) / cluster.k;
                                y2 = centerY - radius;
                            }
                            else if (y2 > centerY + radius)
                            {
                                x2 = (centerY + radius - cluster.b) / cluster.k;
                                y2 = centerY + radius;
                            }

                            if (x1 < centerX - radius)
                            {
                                y1 = cluster.k * (centerX - radius) + cluster.b;
                                x1 = centerX - radius;
                            }
                            else if (x1 > centerX + radius)
                            {
                                y1 = cluster.k * (centerX + radius) + cluster.b;
                                x1 = centerX + radius;
                            }

                            if (x2 < centerX - radius)
                            {
                                y2 = cluster.k * (centerX - radius) + cluster.b;
                                x2 = centerX - radius;
                            }
                            else if (x2 > centerX + radius)
                            {
                                y2 = cluster.k * (centerX + radius) + cluster.b;
                                x2 = centerX + radius;
                            }
                            #endregion

                            try
                            {
                                Pen pen = new Pen(colors[cluster.Id]);
                                graphics.DrawEllipse(Pens.Black,
                                (int)((cluster.Center.X - radius) * size + 200),
                                (int)((cluster.Center.Y - radius) * size + 200),
                                (int)(radius * 2 * size),
                                (int)(radius * 2 * size));


                                graphics.DrawLine(pen, (int)(x1 * size + 200),
                                                            (int)(y1 * size + 200),
                                                            (int)(x2 * size + 200),
                                                            (int)(y2 * size + 200));
                            }
                            catch { }
                        
                    }
                }
            }
            return bitmap;

        }

        private void SearchWall(Cluster[] clusters)
        {
            double thresholdAngle = (double)numericUpDown_angl.Value * Math.PI / 180;
            double threshold = (double)numericUpDown_R.Value;

            List<List<Cluster>> groups = new List<List<Cluster>>();
            List<Cluster> ungroupedClusters = new List<Cluster>(clusters);

            lines.Clear();
            while (ungroupedClusters.Count > 0)
            {
                // Создаем новую группу и добавляем в нее первый кластер из списка несгруппированных
                List<Cluster> currentGroup = new List<Cluster> { };
                currentGroup.Add(ungroupedClusters[0]);
                ungroupedClusters.RemoveAt(0);
                for (int j = 0; j < currentGroup.Count; j++)
                {
                    for (int i = 0; i < ungroupedClusters.Count; i++)
                    {
                        double distance = Math.Sqrt((currentGroup[j].Center.X - ungroupedClusters[i].Center.X) * (currentGroup[j].Center.X - ungroupedClusters[i].Center.X) + (currentGroup[j].Center.Y - ungroupedClusters[i].Center.Y) * (currentGroup[j].Center.Y - ungroupedClusters[i].Center.Y));
                        var dangle = Math.Abs(currentGroup[j].angle - ungroupedClusters[i].angle);
                        if (distance < threshold*2 && dangle <= thresholdAngle)
                        {
                            currentGroup.Add(ungroupedClusters[i]); ;
                            ungroupedClusters.RemoveAt(i);
                            i--;
                        }
                    }
                }

                groups.Add(currentGroup);
            }


            int I = 0;
            for (int i=0; i < groups.Count; i++)
            {
                if (groups[i].Count > 1)
                {
                    PointF firstPoint = groups[i].First().Center;
                    PointF lastPoint = groups[i].Last().Center;
                    for (int j = 0; j < groups[i].Count; j++)
                    {
                        if (groups[i][j].Center.X < firstPoint.X || (groups[i][j].Center.X == firstPoint.X && groups[i][j].Center.Y < firstPoint.Y))
                        {
                            firstPoint = groups[i][j].Center;
                        }
                        if (groups[i][j].Center.X > lastPoint.X || (groups[i][j].Center.X == lastPoint.X && groups[i][j].Center.Y > lastPoint.Y))
                        {
                            lastPoint = groups[i][j].Center;
                        }
                        clusters[I] = groups[i][j];
                        clusters[I].wallId = i;
                        I++;
                    }
                    lines.Add(new Line(firstPoint, lastPoint,i));
                }
            }
        }
        private void CalculateClusterLine(Cluster[] clusters)
        {
            foreach (Cluster cluster in clusters)
            {
                double sumX = 0;
                double sumY = 0;
                double sumXY = 0;
                double sumX2 = 0;
                foreach (PointF point in cluster.Points)
                {
                    sumX += point.X;
                    sumY += point.Y;
                    sumXY += point.X * point.Y;
                    sumX2 += point.X * point.X;
                }
                double n = cluster.Points.Count();
                cluster.k = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
                cluster.b = (sumY - cluster.k * sumX) / n;
                cluster.angle = Math.Abs(Math.Atan(cluster.k));
            }

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


        public class Cluster
        {
            public int Id;// Идентификатор кластера
            public List<PointF> Points; // Список точек кластера
            public PointF Center; // Центр кластера
            public double angle; // Прямая
            public double k;
            public double b;
            public int wallId;
            public Cluster(int id, List<PointF> points, PointF center)
            {
                Id = id;
                Points = points;
                Center = center;
            }
        }
        public class Line
        {
            public PointF firstPoint;
            public PointF lastPoint;
            public int lineId;

            public Line(PointF start,
                        PointF finish,int lineId)
            {
                this.firstPoint = start;
                this.lastPoint = finish;
                this.lineId = lineId;
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
            Draw();
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
            //listBox1.Items.Add(sByte);
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
                    byte[] bytes = listener.Receive(ref groupEP);
                    Invoke(new AddItemDelegate(AddItem), new object[] { bytes });
                }
            }
            catch {}
            finally
            {
                listener.Close();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t != null)
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
