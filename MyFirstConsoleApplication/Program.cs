using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "River Rhodes";
            string myLocal = "Indiana, USA";

            Console.WriteLine($"Hello, my name is {myName} and I am from {myLocal}");

            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(currentDate);

            int whenXmas = (new DateTime(DateTime.Today.Year, 12, 25) - DateTime.Today).Days;

            if (whenXmas < 0)
                whenXmas = (new DateTime(DateTime.Today.Year + 1, 12, 25) - DateTime.Today).Days;

            Console.WriteLine($"The number of days until Christmas is {whenXmas}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter width");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter height");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
