using System;

public class Program
{
    public static void Main(string[] args)
    {

        double buffetPrice = 9.99;
        double coffee = 2.00;
        double water = 0;
        int waterOrdered = 0;
        int coffeeOrdered = 0;

        Console.WriteLine($"Hi. Welcome to our Buffet. All you can eat for ${buffetPrice}! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
        int partySize = Int32.Parse(Console.ReadLine());

        if (partySize <= 5)
        {
            for (int i = 0; i < partySize; i++)
            {
                Console.WriteLine($"Alright, person number {i + 1}, water or coffee?");
                string drinkOrder = Console.ReadLine();

                if (drinkOrder == "water")
                {
                    waterOrdered += 1;
                    Console.WriteLine("Water, good choice!");
                }
                else if (drinkOrder == "coffee")
                {
                    coffeeOrdered += 1;
                    Console.WriteLine("Coffee, okay!");
                }
                else
                {
                    Console.WriteLine("Sorry we do not have that beverage.");
                }
            }

            Console.WriteLine($"Okay, so that's {coffeeOrdered} coffee(s) and {waterOrdered} water(s). I'll be right back. Feel free to grab your food! \n");

            double totalPrice = (partySize * buffetPrice) + (coffee * coffeeOrdered) + (water * waterOrdered);

            Console.WriteLine($"Here's your bill! Total price: ${totalPrice}");
        }
        else
        {
            Console.WriteLine("Oh sorry, we only seat parties up to 6. Have a nice day!");
        }
    }
}

