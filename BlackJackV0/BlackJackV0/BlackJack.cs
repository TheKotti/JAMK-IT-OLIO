using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {
            Console.WriteLine("Lotto (1) vai Blackjack (2)");
            string valinta = Console.ReadLine();

            if (valinta == "1")
            {
                Lotto.Lottoa();
            }
            else if (valinta == "2")
            {
                PlayBlackJack();
            }
            else
            {
                Console.WriteLine("No ei pelata");
            }
    }
        static void PlayBlackJack()
        {
            string theirNumber = "";
            int temp;
            while (true)
            {
                Random rnd = new Random();
                int myNumber = rnd.Next(10, 22);
                System.Console.WriteLine("*** BlackJack! ***");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                theirNumber = System.Console.ReadLine();
                //comparing that given umber is valid
                if (!int.TryParse(theirNumber, out temp))
                {
                    if (theirNumber == "x" || theirNumber == "exit" || theirNumber == "X")
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Ei näin");
                    theirNumber = Console.ReadLine();
                    int.TryParse(theirNumber, out temp);
                }
                while (temp < 1 || temp > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                    theirNumber = Console.ReadLine();
                    int.TryParse(theirNumber, out temp);
                }

                //comparing
                Console.WriteLine("Dealer's number: " + myNumber);
                if (temp >= myNumber && temp <= 21)
                {
                    System.Console.WriteLine("You win. Play again.");
                }
                else
                {
                    System.Console.WriteLine("You lose. Play again.");
                }
            }
        }
  }
}