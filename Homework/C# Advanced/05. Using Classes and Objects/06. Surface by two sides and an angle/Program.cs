using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Surface_by_two_sides_and_an_angle
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, angle);
            Console.WriteLine("{0:F2}" , triangle.CalculateArea());
        }
    }

    class Triangle
    {
        private double sideA;
        private double sideB;
        private double angle;

        public Triangle(double sideA, double sideB, double angle)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = (angle * Math.PI) / 180;
        }

        public double CalculateArea()
        {
            double area = Convert.ToDouble((sideA * sideB * Math.Sin(angle)) / 2);
            return area;
        }
    }
}
