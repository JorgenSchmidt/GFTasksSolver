using Core.Entities;
using System;
using System.Collections.Generic;

namespace Model.CalculateAnomalyService
{
    public class AnomalyPointsClass
    {
        // Для создания динамического массива с данными по аномалии
        // Генерируется по частоте дискретизации и параметрам моделируемой среды
        public static List<AbstractPoint> GetAnomalyPoints(
                        int samplingRate,
                        decimal x_Max,
                        decimal depthLowerEdge,
                        decimal depthHigherEdge,
                        decimal hostRocksDensity,
                        decimal ledgeRocksDensity,
                        decimal overhangLocation
            )
        {
            List<AbstractPoint> anomalyPoints= new List<AbstractPoint>();
            decimal increment_X = x_Max / samplingRate;
            for (decimal X = 0; X <= x_Max; X += increment_X)
            {
                anomalyPoints.Add(
                    new AbstractPoint()
                    {
                        X = X,
                        Y = GravityOverLedgeCalculator.CalculateGravityOverLedge(
                            X,
                            depthLowerEdge,
                            depthHigherEdge,
                            hostRocksDensity,
                            ledgeRocksDensity,
                            overhangLocation
                          )
                    }
                );
            }
            return anomalyPoints;
        }

        public static decimal GetMaxFromAnomalyList (List<AbstractPoint> anomalyPoints)
        {
            decimal answer = Decimal.MinValue;
            foreach (var point in anomalyPoints)
            {
                if (answer < point.Y)
                {
                    answer = point.Y;
                }
            }
            return answer;
        }
    }
}