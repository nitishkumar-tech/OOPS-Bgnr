//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Metadata.W3cXsd2001;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS_Begnr
//{
//    internal class CarParameterCons
//    {
//        class car
//        {
//            string model;
//            string color;
//            int year;


//            public car(string Model, string Color, int Year)
//            {
//                model = Model;
//                color = Color;
//                year = Year;
//                if (year <= 1885)
//                {
//                    Console.WriteLine("car not found");
//                }
//                else
//                {
//                    Console.WriteLine("car manufactured year is :" + year);
//                }
//            }
//            public void cardisplay()
//            {
//                Console.WriteLine("car mode is :" + model);
//                Console.WriteLine("car color is :" + color);


//            }
//        }
//        static void Main(string[] args)
//        {
            

//            car obj = new car("BMW", "Blue", 1886);
//                obj.cardisplay();

//            car obj1 = new car("Audi", "red", 1885);
//            obj.cardisplay();
//        }
//    }
//}
