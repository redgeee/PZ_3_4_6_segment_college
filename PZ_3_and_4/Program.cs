namespace PZ_3_and_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            // Создание списка отрезков
            List<LineSegment> lines = new List<LineSegment>();

            for (int i = 0; i < 100; i++)
            {
                Point point1 = new Point(rd.Next(-20, 20), rd.Next(-20, 20));
                Point point2 = new Point(rd.Next(-20, 20), rd.Next(-20, 20));
                
                lines.Add(new LineSegment(point1, point2));
            }

            // Ордината второй точки превышает первую
            List<LineSegment> newListLines = lines.Where(x => x.Point2.CoordY > x.Point1.CoordY).ToList();
            newListLines.ForEach(x => Console.WriteLine(x));

            // Сохранение абсцисс точек в отдельный список
            List<double> ListAbscissaLine = new List<double>();

            ListAbscissaLine.AddRange(newListLines.Select(x => x.Point1.CoordX).ToList());
            ListAbscissaLine.AddRange(newListLines.Select(x => x.Point2.CoordX).ToList());
        }
    }
}
