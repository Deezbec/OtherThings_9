using System;

namespace В_ожидании_учителей
{
    class Program
    {
        class Point2D
        {
            private double x;
            private double y;
            public Point2D()
            {
                x = 0;
                y = 0;
            }
            public Point2D(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double X { get { return x; } }
            public double Y { get { return y; } }
            public void changer()
            {
                string[] s = Console.ReadLine().Split();
                switch (Convert.ToInt32(s[0]))
                {
                    case 1: y += Convert.ToInt32(s[1]); break;
                    case 2: x += Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; y += Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; break;
                    case 3: x += Convert.ToInt32(s[1]); break;
                    case 4: x += Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; y -= Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; break;
                    case 5: y -= Convert.ToInt32(s[1]); break;
                    case 6: x -= Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; y -= Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; break;
                    case 7: x -= Convert.ToInt32(s[1]); break;
                    case 8: x -= Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; y += Convert.ToInt32(s[1]) * Math.Sqrt(2) / 2; break;
                }
            }
            public string AnnoyingSoundDirection(Point2D Boy, Point2D Karlson)
            {
                double temp = (Boy.x - this.x) * (Karlson.y - this.y) - (Karlson.x - this.x) * (Boy.y - this.y);
                if (temp > 0) return "LEFT";
                else if (temp < 0) return "RIGHT"; else return "BOTH";
            }
            public double DistanceBetweenTwoDots(Point2D SecondOne)
            {
                double a = Math.Abs(this.x - SecondOne.x);
                double b = Math.Abs(this.y - SecondOne.y);
                return Math.Sqrt(a * a + b * b);
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
        static void Forth()
        {
            Point2D Treasure = new Point2D();
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++) Treasure.changer();
            Console.WriteLine($"{Treasure.X:F3} {Treasure.Y:F3}");
        }
        static void Fifth()
        {
            Point2D[] MassOfDots = new Point2D[Convert.ToInt32(Console.ReadLine())];
            double maxDistance = 0, x;
            string[] s;
            for (int i = 0; i < MassOfDots.Length; i++) 
            { s = Console.ReadLine().Split(); MassOfDots[i] = new Point2D(Convert.ToDouble(s[0]), Convert.ToDouble(s[1])); }
            for (int i = 0; i < MassOfDots.Length; i++)
                for (int j = i + 1; j < MassOfDots.Length; j++)
                { x = MassOfDots[i].DistanceBetweenTwoDots(MassOfDots[j]); if (x > maxDistance) maxDistance = x; }
            Console.WriteLine($"{maxDistance:F13}");
        }
        static void Main(string[] args)
        {
            Fifth();
        }
    }
}
