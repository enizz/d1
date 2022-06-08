using System;

namespace Deliverable_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi. Welcome to our Buffet! All you can eat for " +
                "just $9.99! We only charge extra for coffee. How many people " +
                "are in your group? Please, parties of 6 or lower.");


            int guests = Convert.ToInt32(Console.ReadLine());

            if (guests > 6) {
                Console.WriteLine("Kick rocks.");
                return; }

            Console.WriteLine("A table for " + guests + ". Right this way.");
            Console.WriteLine();
            Console.WriteLine("Let's get everyone started with your drink " +
                "orders.. Coke or Pepsi.");

            int Cokes = 0;
            int Pepsis = 0;

            for (int i = 1; i < (guests + 1); i++)
            {
                Console.WriteLine("Alright, guest " + i + ", Coke or Pepsi?");
                string drink = Console.ReadLine();

                if (drink == "Coke" || drink == "Pepsi") { Console.WriteLine(drink +", OK."); }
                else Console.WriteLine("Kick rocks.");



                if (drink == "Coke") { Cokes++; }
                if (drink == "Pepsi") { Pepsis++; }
            }

            Console.WriteLine();
            Console.WriteLine("Alright, that's " + Cokes + " Cokes and " + Pepsis + " " +
                "Pepsis. I'll be right back with that. Feel free to grab your food.");

            double buffprice = guests * 9.99;
            double drinkprice = (Cokes + Pepsis) * 1.99;
            double totalprice = buffprice + drinkprice;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is the bill! Total price: $"+ totalprice);
            

        }
    }
}
