using System;

namespace В_ожидании_учителей
{
    class Program
    {
        class Point2D
        {
            private double x;
            private double y;
            public Point2D(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double X { get { return x; } }
            public double Y { get { return y; } }
            public string AnnoyingSoundDirection(Point2D Boy, Point2D Karlson)
            {
                double temp = (Boy.x - this.x) * (Karlson.y - this.y) - (Karlson.x - this.x) * (Boy.y - this.y);
                if (temp > 0) return "LEFT";
                else if (temp < 0) return "RIGHT"; else return "BOTH";
            }
        }
        static void First()
        {
            string[] s = Console.ReadLine().Split();
            Point2D bok = new Point2D(Convert.ToInt32(s[0]), Convert.ToInt32(s[1])),
                    boy = new Point2D(Convert.ToInt32(s[2]), Convert.ToInt32(s[3])),
                    karlson = new Point2D(Convert.ToInt32(s[4]), Convert.ToInt32(s[5]));
            Console.WriteLine(bok.AnnoyingSoundDirection(boy, karlson));
        }
        static void Third()
        {
            int direction = 0, k = 0;
            string[] s;
            Point2D[] mass = new Point2D[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < mass.Length; i++)
            { s = Console.ReadLine().Split(); mass[i] = new Point2D(Convert.ToDouble(s[0].Replace(".",",")), Convert.ToDouble(s[1].Replace(".", ","))); }
            if (mass[0].X == mass[1].X && mass[0].Y < mass[1].Y) direction = 1;
            if (mass[0].X == mass[1].X && mass[0].Y > mass[1].Y) direction = 2;
            if (mass[0].X > mass[1].X && mass[0].Y == mass[1].Y) direction = 3;
            if (mass[0].X < mass[1].X && mass[0].Y == mass[1].Y) direction = 4;
            for (int i = 2; i < mass.Length; i++)
            {
                if (direction == 1) if (mass[i].X < mass[i - 1].X) { k++; direction = 3; }
                if (direction == 2) if (mass[i].X > mass[i - 1].X) { k++; direction = 2; }
                if (direction == 3) if (mass[i].Y < mass[i - 1].Y) { k++; direction = 4; }
                if (direction == 4) if (mass[i].Y > mass[i - 1].Y) { k++; direction = 1; }
            }
            Console.WriteLine(k);
        }
        static void Main(string[] args)
        {
            Third();
        }
    }
}
