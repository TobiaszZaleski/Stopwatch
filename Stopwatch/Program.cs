using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool Condition = true;
            var stopwatch = new Stopwatch();


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Wpisz \"Start\", aby zacząć odliczanie oraz \"Stop\" aby je zatrzymac, mozesz wpisac \"Zakoncz\" \naby zakończyć działanie programu");
                    var tekst = Console.ReadLine();


                    if (tekst == "Start")
                    {
                        stopwatch.Start();
                        break;
                    }
                    else if (tekst == "Zakoncz")
                    {
                        Condition = false;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Taka operacja nie może zostać wykonana");
                        continue;
                    }
                }




                if (Condition==false)
                {
                    break;
                }




                while (true)
                {

                    Console.WriteLine("Aby zakonczyc pomiar wpisz \"Stop\", aby wykonac miedzyczas wpisz \"Nastepny\" lub \"Zakoncz\" aby wyłączyć program.");
                    var tekst2 = Console.ReadLine();


                    if (tekst2 == "Nastepny")
                    {
                        Console.WriteLine("Stop Message: " + stopwatch.Stop);
                    }
                    else if (tekst2 == "Stop")
                    {
                        Console.WriteLine("Stop Message: " + stopwatch.Stop);
                        break;
                    }
                    else if (tekst2 == "Zakoncz")
                    {
                        Condition = false;
                        break;
                    }
                    else
                        throw new InvalidOperationException("Taka operacja nie może zostać wykonana po rozpoczęciu odliczania");
                }


                if (Condition == false)
                {
                    break;
                }


                Console.WriteLine("Wpisz \"1\" aby kontynuować lub \"2\" aby zakonczyc");
                var tekst3 = Console.ReadLine();


                if (tekst3 == "1")
                {
                    Console.Clear();
                    continue;
                }
                else if (tekst3 == "2")
                {
                    break;
                } 
                else
                    throw new InvalidOperationException("Taka operacja nie może zostać wykonana, program zostanie zamkniety");

            }
        }
    }
}
