using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Assignment_G2
{
    internal class Rectangle : IRectangle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("The shape is rectangle");
        }
    }
}
