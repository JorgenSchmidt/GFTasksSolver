using System;

namespace Model.CalculateAnomalyService
{
    public class GravityOverLedgeCalculator
    {

        private const decimal G = 0.00667M;
        private const decimal PI = 3.141593M;

        public static decimal CalculateGravityOverLedge (
                        decimal X, 
                        decimal depthLowerEdge, 
                        decimal depthHigherEdge, 
                        decimal hostRocksDensity, 
                        decimal ledgeRocksDensity, 
                        decimal overhangLocation
            )
        {
            return G*(ledgeRocksDensity - hostRocksDensity) * (PI*(depthLowerEdge - depthHigherEdge) 
                + 2 * Convert.ToDecimal(Math.Atan(Convert.ToDouble((X - overhangLocation) / depthLowerEdge))) 
                + 2 * Convert.ToDecimal(Math.Atan(Convert.ToDouble((X - overhangLocation) / depthHigherEdge)))
                + (X - overhangLocation) * Convert.ToDecimal( Math.Log(Convert.ToDouble(
                     ((X - overhangLocation) * (X - overhangLocation) + depthLowerEdge * depthLowerEdge)
                     /
                     ((X - overhangLocation) * (X - overhangLocation) + depthHigherEdge * depthHigherEdge)
                )))
            );
        }
    }
}