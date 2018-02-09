using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop1
{
    class Program1_1a
    {
        static void Main(string[] args)
        {

        }
    }

    class Triangle
    {
        double baseLength;
        double side1;
        double side2;
        double height;

        double FindArea()
        {
            return baseLength * height / 2;
        }

        double FindPerimeter()
        {
            return baseLength + side1 + side2;
        }

        public Triangle()
        {

        }
    }
    
    class Rectangle
    {
        double length;
        double breadth;

        double FindArea()
        {
            return length * breadth;
        }

        double FindPerimeter()
        {
            return 2*(length+breadth);
        }
    }

    class Circle
    {
        double radius;

        double FindArea()
        {
            return Math.PI * radius * radius;
        }

        double FindPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
