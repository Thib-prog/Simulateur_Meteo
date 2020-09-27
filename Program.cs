using System;

namespace SimulateurMeteo
{
    class Program
    {




        static void Main(string[] args)
        {
            Meteo m = new Meteo();
            Meteo.changementMeteoDel delegateActionAuChangementMeteo = ActionAuChangementMeteo;
            m.ChangementMeteo += delegateActionAuChangementMeteo;


            Console.WriteLine("Combien de mesures doivent être générées?");
            ConsoleKeyInfo key1 = Console.ReadKey();
            if (!char.IsDigit(Convert.ToChar(key1.Key)))
            {
                Console.WriteLine("Not a digit");
                return;
            }
            int intKey = int.Parse(key1.KeyChar.ToString());
            int[] arrayRnd = new int[intKey];
            Random rnd = new Random();
            for (int i = 0; i < arrayRnd.Length; i++)
            {
                arrayRnd[i] = rnd.Next(0, 100);
                Console.WriteLine("New rnd : " + arrayRnd[i]);
                m.CheckWeather(arrayRnd[i]);
                //for (int j = 0; j < 10000; j++);
            }
            Console.WriteLine(" Press any key to exit ...");
            Console.ReadKey();
        }
        public static  void ActionAuChangementMeteo(Meteo.MeteoEnum newMeteo)
        {
            Console.WriteLine("The new meteo is :" +newMeteo);
        }


    }
}
