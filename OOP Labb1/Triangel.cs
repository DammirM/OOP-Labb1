using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb1
{
    class Triangel
    {
        public int Base;
        public int Length;

        public Triangel(int bas, int hight)
        {
            Length = hight;
            Base = bas;

        }

        public int TriangelArea()
        {
            return Base * Length * 2;

        }

        public int TriangelVolume()
        {
            return (Base * Length * 2) * Length;
        }

        public int TriangelCircumference()
        {
            return Length + Length + Length;

        }
    }
}
