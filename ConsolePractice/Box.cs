using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Box()
        {

        }
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double CalculateVolume()
        {
            double volume = Length * Width * Height;
            return volume;
        }
    }
}
