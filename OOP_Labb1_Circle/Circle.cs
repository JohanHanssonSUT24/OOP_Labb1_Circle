using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb1_Circle
{
    internal class Circle
    {
        public float Pi { get; set; }
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
            Pi = 3.141f;
        }
        public void GetArea()
        {
            Console.WriteLine($"Arean av en cirkel med radien {Radius} är: {Radius*Radius*Pi}");
        }

    }
}
