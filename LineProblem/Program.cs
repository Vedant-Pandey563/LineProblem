namespace LineProblem
{
    
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }

        public static double LineLength(Point p1, Point p2)
        {
            double Xlength = p2.X - p1.X;
            double Ylength = p2.Y - p1.Y;
            double length = 0;
            length = Math.Sqrt(Math.Pow(Xlength, 2) + Math.Pow(Ylength, 2));
            return length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Computation");

            Console.WriteLine("Enter X and Y values for Point1:");
            Console.Write("X:"); 
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Y:");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Enter X and Y values for Point2:");
            Console.Write("X:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Y:");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Point Pa = new Point(x1,y1);
            Point Pb = new Point(x2,y2);

            double length = Point.LineLength(Pa, Pb);

            Console.WriteLine("Length Between Lines"+  length);
        }
    }
}


