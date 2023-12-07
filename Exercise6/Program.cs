namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(35);
            intStack.Push(45);
            intStack.Push(55);
            intStack.Pop();
            intStack.Push(45);
            intStack.Pop();
            
            Console.WriteLine("Remaining items in the Stack:");
            while (!intStack.IsEmpty())
            {
                Console.WriteLine(intStack.Pop());
            }
        }
    }
}