using System;

namespace W2L7_Homework
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            //Program 1#
            Console.WriteLine("Program 1#\n");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b = Int32.Parse(Console.ReadLine());

            if (a==b)
            {
                Console.WriteLine("Liczby są równe!");
            }
            else
            {
                Console.WriteLine("Liczby są różne");
            }

            //Program 2#
            Console.WriteLine("\nProgram 2#\n");
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int EvenNr = Int32.Parse(Console.ReadLine());

            if (EvenNr % 2 == 0) //dzielenie modulo, jeżeli reszta z dzielenia przez 2 jest równa 0
            {
                Console.WriteLine("Liczby są parzyste!");
            }
            else
            {
                Console.WriteLine("Liczby są nieparzyste");
            }

            //Program 3#
            Console.WriteLine("\nProgram 3#\n");
            Console.WriteLine("Podaj liczbę: ");
            int PlusMinus = Int32.Parse(Console.ReadLine());

            if (PlusMinus < 0) 
            {
                Console.WriteLine("Liczba jest ujemna!");
            }
            else if (PlusMinus > 0)
            {
                Console.WriteLine("Liczba są dodatnia");
            }
            else if (PlusMinus == 0)
            {
                Console.WriteLine("Liczba jest równa zero");
            }

            //Program 4#
            Console.WriteLine("\nProgram 4#\n");
            Console.WriteLine("Podaj rok: ");
            int myYear = Int32.Parse(Console.ReadLine());

            if (myYear % 4==0 && myYear % 100 != 0 || myYear % 400 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }

            //Program 5#
            Console.WriteLine("\nProgram 5#\n");
            Console.WriteLine("Podaj ile masz lat: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz zostać posłem, premierem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz zostać premierem, senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Za młody do polityki");
            }
        }
    }

}
