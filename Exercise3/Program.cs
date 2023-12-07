namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4.5f, 3.2f);
            float area = rectangle.CalculateArea();
            Console.WriteLine("The area of the Rectangle is: " + area);
        }
    }
}