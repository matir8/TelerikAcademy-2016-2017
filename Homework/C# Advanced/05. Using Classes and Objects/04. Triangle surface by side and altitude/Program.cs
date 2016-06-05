using System;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        private double side;
        private double altitude;

        public Triangle(double side, double altitude)
        {
            this.side = side;
            this.altitude = altitude;
        }

        public double CalculateArea()
        {
            double area = (this.side * this.altitude)/2;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(side, altitude);
            Console.WriteLine("{0:F2}", triangle.CalculateArea());
        }
    }
}
