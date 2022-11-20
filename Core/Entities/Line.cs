using System.Windows.Media;

namespace Core.Entities
{
    public class Line
    {
        public int X1 { get; init; }
        public int Y1 { get; init; }
        public int X2 { get; init; }
        public int Y2 { get; init; }
        public SolidColorBrush Color { get; set; }
    }
}