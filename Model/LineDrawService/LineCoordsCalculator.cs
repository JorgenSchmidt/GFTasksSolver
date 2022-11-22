using Core.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Model.LineDrawService
{
    public class LineCoordsCalculator
    {
        public static List<Line> CalculateLinesCoords (
            decimal X_Max,
            decimal Y_Max,
            int CanvasHeight,
            int CanvasWidth,
            List<AbstractPoint> points,
            bool IsMustInverted,
            SolidColorBrush Color
            )
        {
            List<Line> lines = new List<Line>();

            // количество итераций "points.Count - 2" обусловлено тем, что по 
            // n точкам можно построить только n-1 линий
            if ( IsMustInverted )
            {
                for (int i = 0; i <= points.Count - 2; i++)
                {
                    lines.Add(
                        new Line ()
                        {
                            X1 = Convert.ToInt32(points[i].X * (CanvasHeight / X_Max)),
                            Y1 = Convert.ToInt32(CanvasWidth - points[i].Y * (CanvasWidth / Y_Max)),
                            X2 = Convert.ToInt32(points[i + 1].X * (CanvasHeight / X_Max)),
                            Y2 = Convert.ToInt32(CanvasWidth - points[i + 1].Y * (CanvasWidth / Y_Max)),
                            Color = Color
                        }    
                    );
                }
            }
            else
            {
                for (int i = 0; i <= points.Count - 2;  i++)
                {
                    lines.Add(
                        new Line()
                        {
                            X1 = Convert.ToInt32(points[i].X * (CanvasHeight / X_Max)),
                            Y1 = Convert.ToInt32(points[i].Y * (CanvasWidth / Y_Max)),
                            X2 = Convert.ToInt32(points[i + 1].X * (CanvasHeight / X_Max)),
                            Y2 = Convert.ToInt32(points[i + 1].Y * (CanvasWidth / Y_Max)),
                            Color = Color 
                        }
                    );
                }
            }

            return lines;
        }
    }
}