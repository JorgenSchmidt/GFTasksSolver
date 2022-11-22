namespace Model.CheckEnvironmentModelService
{
    public class EnvironmentParamsChecker
    {
        public static bool CheckEnvironmentParams(
                        decimal depthLowerEdge,
                        decimal depthHigherEdge,
                        decimal hostRocksDensity,
                        decimal ledgeRocksDensity,
                        decimal overhangLocation
            )
        {
            return (depthLowerEdge > 0)
                && (depthHigherEdge > 0)
                && (depthLowerEdge >= depthHigherEdge)
                && (hostRocksDensity > 0)
                && (ledgeRocksDensity > 0)
                && (ledgeRocksDensity > hostRocksDensity)
                && (overhangLocation >= 1);
        }
    }
}