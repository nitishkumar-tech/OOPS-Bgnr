using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Begnr
{
    internal class CarParameterCons
    {
        class car
        {
            string model;
            string color;
            int year;


            public car(string model, string color, int year)
            {
                this.model = model;
                this.color = color;
                this.year = year;
            }
            public void cardisplay()
            {
                Console.WriteLine("car mode is :" + model);
                Console.WriteLine("car color is :" + color);
                Console.WriteLine("car manufactured year is :" + year);
            }
        }
        static void Main(string[] args)
        {
            car obj = new car("BMW", "Blue", 2025);
            obj.cardisplay();
        }
    }
}
