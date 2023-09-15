using System;

namespace Atte
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            string långttext = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string hoppadetext = Console.ReadLine();
            double långt = double.Parse(långttext);
            double hoppade = double.Parse(hoppadetext);
            double skillnad = långt - hoppade;
            Console.WriteLine("Elin hoppade " +skillnad+ " meter mer än Alma");
        }
    }
}