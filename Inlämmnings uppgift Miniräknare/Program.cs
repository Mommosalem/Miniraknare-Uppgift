using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare_uppgift
{
    class Program
    {
        static void RunCalculater()    
        {
            Console.Clear();
           
            Console.WriteLine("[1] Miniräknare ");
            Console.WriteLine("[5]Avsluta");





        }
        static void Main(string[] args)
        {
            double tal1 ;
            double tal2;
            char Operator;
            double sum;

            List<string> Previus = new List<string>();


            bool displayMenu = true;

            while (displayMenu)
            {
                RunCalculater();

                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("ange tal1: ");
                    tal1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ange tal2: ");
                    tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("skriv in operator: ");
                    Operator = Convert.ToChar(Console.ReadLine());

                    if (Operator == '+')
                    {
                        sum = tal1 + tal2;

                        Console.WriteLine("{0} + {1} = {2}", tal1, tal2, sum);
                        Previus.Add(string.Format("{0} + {1} = {2}", tal1, tal2, sum));

                    }
                    else if (Operator == '-')
                    {
                        sum = tal1 + tal2;

                        Console.WriteLine("{0} - {1} = {2}", tal1, tal2, sum);
                        Previus.Add(string.Format("{0} - {1} = {2}", tal1, tal2, sum));
                    }
                    else if (Operator == '*')
                    {
                        sum = tal1 * tal2;

                        Console.WriteLine("{0} * {1} = {2}", tal1, tal2, sum);
                        Previus.Add(string.Format("{0} * {1} = {2}", tal1, tal2, sum));
                    }
                    else
                    {
                        sum = tal1 / tal2;

                        Console.WriteLine("{0} / {1} = {2}", tal1, tal2, sum);
                        Previus.Add(string.Format("{0} / {1} = {2}", tal1, tal2, sum));
                    }

                    Console.WriteLine("vill du starta om? J/N ");
                    string choice = Console.ReadLine();
                    if (choice == "N")
                    {
                        Console.WriteLine("Vill du se senaste? J/N");
                        choice = Console.ReadLine();
                        if (choice == "J")
                        {
                            foreach (string calculation in Previus)
                            {
                                Console.WriteLine("Här: " + calculation);
                                Console.ReadKey();
                            }



                        }
                        else
                        {
                            displayMenu = false;
                        }
                    }
                    
                    
                }
                else
                {
                    break;
                }

                        



                        
                        
                
            }

        }
    }
}