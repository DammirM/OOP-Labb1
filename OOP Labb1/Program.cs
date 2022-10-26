using System;

namespace OOP_Labb1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Triangel with the radius 5
            Circle Five = new Circle(5);
            Console.WriteLine("Circle 1: ");
            Console.WriteLine("Area of the Circle is: " + Five.getArea());
            Console.WriteLine("Circumference of the Circle is: " + Five.Circumference());

            Console.WriteLine("----------             --------------");
            

            // Triangel with the radius 6
            Circle Six = new Circle(6);
            Console.WriteLine("Circle 2: ");
            Console.WriteLine("Area of the Circle is: " + Six.getArea());
            Console.WriteLine("Circumference of the Circle is: " + Six.Circumference());

            Console.WriteLine("----------             --------------");

            Circle Cylinder = new Circle(5, 7);
            Console.WriteLine("Cylinder: ");
            Console.WriteLine("Volume of the Cylinder is: " + Cylinder.Volume());

            Console.WriteLine("----------             --------------");

            // Triangel area and volume
            Triangel Tri = new Triangel(4, 5);
            Console.WriteLine("Tringel: ");
            Console.WriteLine("Triangel area is: " + Tri.TriangelArea());
            Console.WriteLine("Triangel Volume is: " + Tri.TriangelVolume());
            Console.WriteLine("Triangel circumference is: ");

            Console.ReadKey();
        }
    }
}
