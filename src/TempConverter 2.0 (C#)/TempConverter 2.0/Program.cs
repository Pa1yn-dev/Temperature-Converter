using System;

namespace TempConverter_2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                // Created by Peter Hamilton
                // 21:02 07/10/2019
                // Converts a range of different temperature scales

                // Colour of the text
                Console.ForegroundColor = ConsoleColor.Red;

                // Asks for type of converter
                Console.WriteLine("What converter do you want? ");
                Console.WriteLine("Celsuis To Farenheight(1) \n Farenheight To Celsuis(2) \n Celsuis To Kelvin(3) \n Farenheight to Kelvin(4)  ");
                Console.WriteLine("Kelvin to Farenheight(5) \n Kelvin to celsuis(6) ");

                // Stores user input
                int deci = Convert.ToInt32(Console.ReadLine());

                // Calls method depending on user input
                switch (deci)
                {
                    case 1:
                        Celsu();
                        Console.WriteLine("Celsuis to farenheight");
                        break;
                    case 2:
                        Farenh();
                        Console.WriteLine("farenheight to celsuis");
                        break;
                    case 3:
                        CeltoKel();
                        Console.WriteLine("Celsuis to Kelvin");
                        break;
                    case 4:
                        faToKel();
                        Console.WriteLine("Farenheight to Kelvin");
                        break;
                    case 5:
                        keltofar();
                        Console.WriteLine("Kelvin to Farenheight");
                        break;
                    case 6:
                        Keltocel();
                        Console.WriteLine("Kelvin to celsuis");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid Number");
                        Console.ReadKey();
                        break;
                }


            }






        }



        // Celsuis to farenheigh
        public static void Celsu()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter celsuis: ");
            string celsuis = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int cels;
            cels = Convert.ToInt32(celsuis);

            double faren = cels * 1.8 + 32;
            Console.WriteLine("Farenheigh: " + faren + "°F");


            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Celsu();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }
        }

        // Farenheigh to celsuis
        public static void Farenh()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter Farenheigh: ");
            string faren = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int far;
            far = Convert.ToInt32(faren);

            double cels = (far - 32) * 5 / 9;
            Console.WriteLine("Celsuis: " + cels + "°C");


            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Farenh();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }

        }

        // Celsuis to kelvin
        public static void CeltoKel()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter Celsuis: ");
            string celsuis = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int cels;
            cels = Convert.ToInt32(celsuis);

            double kel = cels + 273.15;
            Console.WriteLine("Kelvin: " + kel + "K");

            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    CeltoKel();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }
        }

        // Farenheigh to kelvin
        public static void faToKel()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter Farenheight: ");
            string faren = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int far;
            far = Convert.ToInt32(faren);

            double kelv = (far + 459.67) / 1.8;
            Console.WriteLine("Kelvin: " + kelv + "K");

            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    faToKel();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }


        }

        // Kelvin to farenheigh
        public static void keltofar()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter Kelvin: ");
            string Kelv = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int kev;
            kev = Convert.ToInt32(Kelv);

            double farh = (kev - 273.15) * 1.8000 + 32.00;
            Console.WriteLine("Farenheight: " + farh + "°F");

            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    keltofar();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }
        }

        // Kelvin to celsuis
        public static void Keltocel()
        {
            Console.WriteLine("Temperature Converter ");
            Console.WriteLine(" Enter Kelvin: ");
            string Kelv = Console.ReadLine();
            Console.WriteLine("Converting.......");
            int kev;
            kev = Convert.ToInt32(Kelv);

            double cel = kev - 273.15;
            Console.WriteLine("celsuis: " + cel + "°C");

            Console.WriteLine("Would you like to repeat the program? \n (1) Yes \n (2) No");
            int userinput = Convert.ToInt32(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Keltocel();
                    break;
                case 2:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }


        }


    }

}