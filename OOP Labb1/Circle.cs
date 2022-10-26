using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb1
{
    class Circle
    {
        public float Pi = 3.14f;
        public int Radius;
        public int Hight;

        // Constructor for Circle to measure area and circumference
        public Circle(int radius)
        {
            Radius = radius;

        }

        // Created a new constructor for Cylinder
        public Circle(int radius, int hight)
        {
            Radius = radius;
            Hight = hight;
        }


        // Circle methods
        public float getArea()
        {

            return Radius * Radius * Pi;
        }

        public float Circumference()
        {

            return Radius + Radius * Pi;
        }

        // Cylinder method
        public float Volume()
        {
            return (Radius * Radius * Pi) * Hight;

        }
    
    }
}
