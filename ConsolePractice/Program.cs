using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            Box box2 = new Box();

            Console.WriteLine("Enter the Length of box 1: ");
            box.Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of box 1: ");
            box.Width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height of box 1: ");
            box.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Box 1 dimensions are: {box.Length} {box.Width} {box.Height}.");
            Console.WriteLine($"Volume of box 1: {box.CalculateVolume()}\n");

            Console.WriteLine("Enter the Length of box 2: ");
            box2.Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width of box 2: ");
            box2.Width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height of box 2: ");
            box2.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Box 2 dimensions are: {box2.Length} {box2.Width} {box2.Height}.");
            Console.WriteLine($"Volume of box 2: {box2.CalculateVolume()}");

            Person person = new Person();
            person.GetSalary();

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            string wholeName = person.GetFullName();
            Console.WriteLine($"Your full name is: {wholeName}");

            Console.ReadLine();

        }
    }
}
