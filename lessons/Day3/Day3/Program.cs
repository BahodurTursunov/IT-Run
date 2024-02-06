namespace Day3
{
    public struct Point
    {
        public int x;

        public string y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { x = 10, y = "234" };
            Console.WriteLine(p.x, p.y);
        }
    }

    public record  Omega
    {

    }
}
