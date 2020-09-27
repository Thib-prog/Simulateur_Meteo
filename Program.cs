using System;

namespace SimulateurMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de mesures doivent être générées?");
            ConsoleKeyInfo key1 = Console.ReadKey();
            if (!char.IsDigit(Convert.ToChar(key1)))
            {
                Console.WriteLine("Not a digit");
                return;
            }
            int[] arrayRnd = new int[Convert.ToInt16(key1)];
            Random rnd = new Random();
            for (int i = 0; i < arrayRnd.Length; i++)
            {
                arrayRnd[i]=rnd.Next(0, 100);
            }
            Console.WriteLine(" Press any key to exit ...");
            Console.ReadKey();
        }

        
    }
}
