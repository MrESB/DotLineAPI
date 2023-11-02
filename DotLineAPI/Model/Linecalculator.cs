namespace DotLineAPI.Model
{
    public class Linecalculator : IDotLine
    {
        public string IsOnALine(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Dot dot1 = new Dot()
            {
                x = x1,
                y = y1,
            };
            Dot dot2 = new Dot()
            {
                x = x2,
                y = y2,
            };
            Dot dot3 = new Dot()
            {
                x = x3,
                y = y3,
            };
            double m1 = (dot2.y - dot1.y) / (dot2.x - dot1.x);
            double m2 = (dot3.y - dot2.y) / (dot3.x - dot2.x);
            if (m1 == m2)
            {
                string result = "These three dots are on the same line.";

                return result;
            }
            else
            {
                string result = "These Three dots aren't on the same line.";
                return result;
            }
        }
    }
}
