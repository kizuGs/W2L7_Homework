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

            if (a == b)
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

            if (myYear % 4 == 0 && myYear % 100 != 0 || myYear % 400 == 0)
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
                Console.WriteLine("Możesz zostać senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Za młody do polityki");
            }

            //Program 6#

            Console.WriteLine("\nProgram 6#\n");
            Console.WriteLine("Podaj ile masz wzrostu w [mm]: ");

            if (float.Parse(Console.ReadLine()) <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else
            {
                Console.WriteLine("Masz normalny wzrost :) ");
            }

            //Program 7#

            Console.WriteLine("\nProgram 7#\n");
            Console.WriteLine("Podaj pierwsza liczbe : ");
            int L1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe : ");
            int L2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe : ");
            int L3 = Int32.Parse(Console.ReadLine());

            if (L1 > L2 && L1 > L3)
            {
                Console.WriteLine("Pierwsza jest najwieksza");
            }
            else if (L2 > L1 && L2 > L3)
            {
                Console.WriteLine("Druga jest najwieksza");
            }
            if (L3 > L1 && L3 > L2)
            {
                Console.WriteLine("Trzecia jest najwieksza");
            }
            else
            {
                Console.WriteLine("Sa sobie rowne");
            }

            //Program 8#

            Console.WriteLine("\nProgram 8#\n");
            Console.WriteLine("Podaj wynik z matematyki : ");
            int note1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki : ");
            int note2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii : ");
            int note3 = Int32.Parse(Console.ReadLine());

            if ((note1 + note2 + note3 > 180) || (note1 + note2 > 150) || (note1 + note3 > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Za mało punktów");
            }

            //Program 9#

            Console.WriteLine("\nProgram 9#\n");
            Console.WriteLine("Podaj wartosc temperatury ['C] : ");
            float temp1 = float.Parse(Console.ReadLine());

            if (temp1 < 0)
            {
                Console.WriteLine($"Measured value is {temp1}; cholernie zimno.");
            }
            else if (temp1 >= 0 && temp1 < 10)
            {
                Console.WriteLine($"Measured value is {temp1}; zimno");
            }
            else if (temp1 >= 10 && temp1 < 20)
            {
                Console.WriteLine($"Measured value is {temp1}; chłodno");
            }
            else if (temp1 >= 20 && temp1 < 30)
            {
                Console.WriteLine($"Measured value is {temp1}; w sam raz");
            }
            else if (temp1 >= 30 && temp1 < 40)
            {
                Console.WriteLine($"Measured value is {temp1}; zaczyna byc, slabo bo gorąco");
            }
            else
            {
                Console.WriteLine($"Measured value is {temp1}; a weź wyprowadzam się na Alaskę");
            }

            //Program 10#

            Console.WriteLine("\nProgram 10#\n");
            Console.WriteLine("Podaj pierwsza dlugosc trojkata : ");
            int lenght_value1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga dlugosc trojkata : ");
            int lenght_value2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia dlugosc trojkata : ");
            int lenght_value3 = Int32.Parse(Console.ReadLine());

            //Jeśli najdluzszy bok jest krótszy niz suma dwoch pozostalych
            if ((lenght_value1 < lenght_value2 + lenght_value3) && (lenght_value2 < lenght_value1 + lenght_value3) && (lenght_value3 < lenght_value1 + lenght_value2))
            {
                Console.WriteLine($"Można zbudować trójkąt z: {lenght_value1}  { lenght_value2}  { lenght_value3}");
            }
            else
                Console.WriteLine($"Nie da się zbudować trójkąta");

            //Program 11#

            Console.WriteLine("\nProgram 11#\n");

            Console.WriteLine("Jaka jest ocena ucznia:");
            int note_student = int.Parse(Console.ReadLine());


            switch (note_student)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("");
                    break;

            }

            //Program 12#

            Console.WriteLine("\nProgram 12#\n");

            Console.WriteLine("Podaj numer dnia tygodnia 1-pn, 2-wt, 3-śr, 4-czw, 5-pt, 6-sob, 7-nd:");
            int day_of_week = int.Parse(Console.ReadLine());


            switch (day_of_week)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Poza zakresem");
                    break;

            }

            //Program 13#

            Console.WriteLine("\nProgram 13#\n");

            Console.WriteLine("Mini Kalkulator: 1-Dodawanie, 2-Odejmowanie, 3 - Mnożenie, 4- Dzielenie");
            Console.WriteLine("Jakie działanie chcesz wykonać:");

            int dzialanie = int.Parse(Console.ReadLine());
            float fliczba1 = 0;
            float fliczba2 = 0;
            float wynik;

            Console.WriteLine("Podaj pierwszą liczbę");
            fliczba1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            fliczba2 = float.Parse(Console.ReadLine());

            switch (dzialanie)
            {
                case 1:
                    wynik = fliczba1 + fliczba2;
                    Console.WriteLine($"Wynik dodawania {wynik}");
                    break;
                case 2:
                    wynik = fliczba1 - fliczba2;
                    Console.WriteLine($"Wynik odejmowanie {wynik}");
                    break;
                case 3:
                    wynik = fliczba1 * fliczba2;
                    Console.WriteLine($"Wynik mnożenia {wynik}");
                    break;
                case 4:
                    if (fliczba2 > 0)
                    {
                        wynik = fliczba1 / fliczba2;
                        Console.WriteLine($"Wynik dzielenia {wynik}");
                    }
                    else
                    {
                        Console.WriteLine($"Dzielenie przez 0!");
                    }
                    break;
                default:
                    Console.WriteLine("Poza zakresem");
                    break;

            }


        }
    }

}
