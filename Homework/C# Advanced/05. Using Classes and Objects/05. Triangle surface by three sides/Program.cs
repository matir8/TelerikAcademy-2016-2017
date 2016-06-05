using System;

namespace _05.Triangle_surface_by_three_sides
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double area = 1;
            double p = (sideA + sideB + sideC)/2;
            area = Math.Sqrt(p*(p - sideA)*(p - sideB)*(p - sideC));
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            double area = triangle.CalculateArea();
            Console.WriteLine("{0:F2}", area);
        }
    }
}
