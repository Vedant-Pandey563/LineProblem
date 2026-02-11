namespace LineProblem
{
    
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }

        
    }

    public class Line
    {
        
        public Point Start { get; }
        public Point End { get; }
        public double Length { get; }

        public Line(Point start,Point end)
        {
            Start = start;
            End = end;
            Length= LineLength();
        }
        public double LineLength()
        {
            double Xlength = End.X - Start.X;
            double Ylength = End.Y - Start.Y;
            double length = 0;
            length = Math.Sqrt(Math.Pow(Xlength, 2) + Math.Pow(Ylength, 2));
            return length;
        }

        public void LineCompare(Line l1,Line l2)
        {
            if (l1.Length.Equals(l2.Length))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Computation");

            //line 1 
            Console.WriteLine("Enter Line1 Points");
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

            Line line1 = new Line(new Point(x1, y1), new Point(x2, y2));

            Console.WriteLine("Length of Line1 "+  line1.LineLength());
            Console.WriteLine();

            //line 2

            Console.WriteLine("Enter Line2 Points");
            Console.WriteLine("Enter X and Y values for Point2:");
            Console.Write("X:");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Y:");
            int y3 = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Enter X and Y values for Point2:");
            Console.Write("X:");
            int x4 = int.Parse(Console.ReadLine());
            Console.Write("Y:");
            int y4 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Line line2 = new Line(new Point(x3, y3), new Point(x4, y4));

            Console.WriteLine("Length Between Line2 " + line2.LineLength());
            Console.WriteLine();

            // comparing line

            Console.WriteLine("Comparing Lines");
            line1.LineCompare(line1,line2);
        }
    }
}


