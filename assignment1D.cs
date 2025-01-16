namespace Assignment1___4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y\t\tx");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }
    }
}
