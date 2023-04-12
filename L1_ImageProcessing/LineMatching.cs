using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L1_ImageProcessing.Form1;
using static System.Windows.Forms.LinkLabel;

namespace L1_ImageProcessing
{
    partial class Matching
    {
        // Функция для вычисления расстояния между двумя точками
        static double Distance(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        // Функция для вычисления угла между двумя линиями
        static double Angle(Line l1, Line l2)
        {
            double dx1 = l1.lastPoint.X - l1.firstPoint.X;
            double dy1 = l1.lastPoint.Y - l1.firstPoint.Y;
            double dx2 = l2.lastPoint.X - l2.firstPoint.X;
            double dy2 = l2.lastPoint.Y - l2.firstPoint.Y;
            return Math.Acos((dx1 * dx2 + dy1 * dy2) / (Distance(l1.firstPoint, l1.lastPoint) * Distance(l2.firstPoint, l2.lastPoint)));
        }

        // Функция для сопоставления линий между кадрами
        public static List<Line> MatchLines(List<Line> linesNew, List<Line> _linesOld)
        {
            // Параметры для определения похожести линий
            double maxDistance = 500; // Максимальное расстояние между концами линий
            double maxAngle = Math.PI / 6; // Максимальный угол между линиями

            int maxLineId = 0;
            foreach (Line line in _linesOld)
            {
                if (line.lineId > maxLineId)
                {
                    maxLineId = line.lineId;
                }
            }
            // Перебираем все линии из первого кадра
            for (int i=0; i< linesNew.Count;i++)
            {
                // Ищем наиболее похожую линию из второго кадра
                int bestMatch = -1;
                double bestScore = double.MaxValue;

                foreach (Line lineOld in _linesOld)
                {
                    // Вычисляем расстояние и угол между линиями
                    double distance = (Distance(linesNew[i].firstPoint, lineOld.firstPoint) + Distance(linesNew[i].lastPoint, lineOld.lastPoint)) / 2;
                    double angle = Angle(linesNew[i], lineOld);

                    // Вычисляем суммарный скор похожести линий
                    double score = distance + angle;

                    // Если скор меньше текущего лучшего и удовлетворяет параметрам похожести, то обновляем лучшее сопоставление
                    if (score < bestScore && distance < maxDistance && angle < maxAngle)
                    {
                        bestMatch = lineOld.lineId;
                        bestScore = score;
                    }
                }

                // Если нашли лучшее сопоставление, то добавляем его в словарь
                if (bestMatch != -1)
                {

                    linesNew[i].lineId= bestMatch;
                }
                else
                {
                    maxLineId++;
                    linesNew[i].lineId = maxLineId;
                }
               
            }
            return linesNew;
        }

        public static List<Blok> MatchBloks(List<Blok> blokNew, List<Blok> bloksOld)
        {
            // Параметры для определения похожести линий
            double maxDistance = 500; // Максимальное расстояние между концами линий
            int maxLineId = 0;
            foreach (Blok line in bloksOld)
            {
                if (line.i > maxLineId)
                {
                    maxLineId = line.i;
                }
            }
            // Перебираем все линии из первого кадра
            for (int i = 0; i < blokNew.Count; i++)
            {
                int bestMatch = -1;
                double bestScore = double.MaxValue;

                foreach (Blok blokOld in bloksOld)
                {
                    // Вычисляем расстояние и угол между линиями
                    double distance = Distance(blokNew[i].Point, blokOld.Point);
                    
                    // Если скор меньше текущего лучшего и удовлетворяет параметрам похожести, то обновляем лучшее сопоставление
                    if (distance < bestScore && distance < maxDistance)
                    {
                        bestMatch = blokOld.i;
                        bestScore = distance;
                    }
                }

                // Если нашли лучшее сопоставление, то добавляем его в словарь
                if (bestMatch != -1)
                {

                    blokNew[i].i = bestMatch;
                }
                else
                {
                    maxLineId++;
                    blokNew[i].i = maxLineId;
                }

            }
            return blokNew;
        }
    }
}
