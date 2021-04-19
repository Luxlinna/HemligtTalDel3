using System;

namespace HemligtTalDel3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1,101);
            int gissa_tal;
            int i = 0;

            do 
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n Skriva in ditt gissa talet från 1 till 100: ");
                    gissa_tal = Convert.ToInt32(Console.ReadLine());
                    i++;

                    if (gissa_tal > slump_tal)
                    {   
                        if (gissa_tal == slump_tal + 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Du är väldigt nära framslumpade talet !!!");
                        } 
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Det är högre än det framslumpade talet ! gissa lägre talet...");
                        }    
                    }
                    else if (gissa_tal < slump_tal)
                    {
                        if (gissa_tal == slump_tal -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Du är väldigt nära framslumpade talet !!!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Det är lägre än det framslumpade talet ! gissa högre talet...");
                        } 
                    }
                    else if (gissa_tal == slump_tal)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Du vinner !!!");
                        Console.Write("Du försöker gissa {0} gånger", i);
                        break;
                    }   
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.Message);
                }

            } while (i < 10);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\nSkriva valfri tangent för att fortsätta ... ");
            Console.ReadKey();
        }
    }
}
