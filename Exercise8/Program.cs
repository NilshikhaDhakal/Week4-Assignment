namespace Exercise8
{
    internal class Program
    {
        static void Main()
        {
            Point2D pointA = new Point2D { X = 4f, Y = 8f };
            Point2D pointB = new Point2D { X = 6f, Y = 12f};

            double distance = DistanceCalculator.CalculateDistance(pointA, pointB);

            Console.WriteLine($"The distance between the point is: { distance:F2}");
        }
    }
}