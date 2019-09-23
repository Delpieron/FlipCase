using System;
using System.Text;

namespace FlipCase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startAgain = false;
            do
            {
                Console.WriteLine("Wpisz text:");
                string text = Console.ReadLine();

                char[] c = text.ToCharArray();
                char[] cUpper = text.ToUpper().ToCharArray();
                char[] cLower = text.ToLower().ToCharArray();


                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == cUpper[i])
                    {
                        c[i] = cLower[i];
                    }
                    else
                    {
                        c[i] = cUpper[i];
                    }
                }
                Console.WriteLine(c);
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
                Console.WriteLine("Chcesz podac inny text? - wcisnij spacje, jezeli chcesz wyjsc wcisnij inny klawisz.");

                var press = Console.ReadKey();

                if (press.Key == ConsoleKey.Spacebar)
                {
                    startAgain = true;
                }
                else
                {
                    startAgain = false;
                }
            }
            while (startAgain);

            


        }
        
        
    }
}
