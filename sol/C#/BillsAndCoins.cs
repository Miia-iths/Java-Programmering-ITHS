/*I still don't really understand why these first things need to be here
I asked my brother about it and kinda get some of it but mostly that they always go there

some of my // is for me to just.. mark what the section does
but I added my thought journey, hopefully in a good way*/

using System;

namespace BillsAndCoins
{
	class Program
	{
		static void Main(string[] args)
        {
            //welcome
            Console.WriteLine("Welcome to Bills and Coins!\nYour total today is ____kr\n");

            //user input
            /*I would like to make it user friendly and use TryParse..
            But I don't feel like I have a grip of that one yet
            and would rather use that in future assignments when I understand it better
            while loops also feels "scary" somehow ^^'
            I also didn't want to copy paste such a large section, smaller things feels more okay*/
            Console.Write("Input total price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Customer paid: ");
            double paid = Convert.ToDouble(Console.ReadLine());

            //counting change
            double noDecimals = paid - price;

            //separating the decimals
            /*this was tricky, I looked for answers at w3schools but couldn't find it in their introduction
            ended up asking chatGPT for help but then also looked up Math.Floor to try understand what it does*/
            double changeBack = Math.Floor(noDecimals);
            double decimalPart = noDecimals - changeBack;
            
            //rounding up or down
            //this felt easier because of the examples in the book
            double fiftyCent;
            if (decimalPart < 0.25)
                fiftyCent = 0.00;
            else if (decimalPart < 0.75)
                fiftyCent = 50;
            else
                fiftyCent = 1.00;
            
            //eventuall addition to 
            if (fiftyCent == 1.00)
                changeBack += 1;
        
            //because who wants all those decimals ^^'
            int forTho = Convert.ToInt32(changeBack);
            
            //the math of bills and coins
            /*I had an idea of what i wanted to do here
            I looked at videos and w3school to understand the %
            but ended up asking chatGPT for the math, after getting a headache ^^'
            making so maany variables is probobly not the most efficiant way
            but I wanted to make it work myself with what I understood so far*/
            int oneThousand = forTho / 1000;
            int remaTho = forTho % 1000;

            int fiveHundred = remaTho / 500;
            int remaFivHun = remaTho % 500;

            int oneHundred = remaFivHun / 100;
            int remaHun = remaFivHun % 100;

            int fifty = remaHun / 50;
            int remaFif = remaHun % 50;

            int twenty = remaFif / 20;
            int remaTwe = remaFif % 20;

            int ten = remaTwe / 10;
            int remaTen = remaTwe % 10;

            int five = remaTen / 5;
            int remaFiv = remaTen % 5;

            int one = remaFiv / 1;

            //bills and coins
            Console.WriteLine("\n\nBills and Coins:");
            /*this part was fun, here I could use what I understood better - loops ^^
            and so satifying - it worked on the first try*/
            if (oneThousand > 0)
                Console.WriteLine($"{oneThousand} x [1000]");
            if (fiveHundred > 0)
                Console.WriteLine($"{fiveHundred} x [500]");
            if (oneHundred > 0)
                Console.WriteLine($"{oneHundred} x [100]");
            if (fifty > 0)
                Console.WriteLine($"{fifty} x [50]");
            if (twenty > 0)
                Console.WriteLine($"{twenty} x [20]");
            if (ten > 0)
                Console.WriteLine($"{ten} x (10)");
            if (five > 0)
                Console.WriteLine($"{five} x (5)");
            if (one > 0)
                Console.WriteLine($"{one} x (1)");
            if (fiftyCent == 50)
                Console.WriteLine($"1 x (50)");

            //present to customer
            Console.Write($"\n\nHere's your change:\n{changeBack} kr");          
            if (fiftyCent == 50)
                Console.Write($" and {fiftyCent} cent");
                //used cent to keep it in english

            Console.WriteLine("\n\nThank you for shopping at Bills and Coins\nHave a cent-santional day!"); 

	    }
	}
}
