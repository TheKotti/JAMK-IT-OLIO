using System;
/// <summary>
/// A simple example of lottery game
/// </summary>
namespace JAMK.IT
{
    public class Lotto
    {
        public static void Lottoa()
        {
            {

                Console.WriteLine("Montako rivia");
                int rivit = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < rivit; i++)
                {
                    int[] numerot = new int[7];
                    Random rnd = new Random();

                    for (int j = 0; j < numerot.Length; j++)
                    {
                        rnd = new Random();
                        int temp = rnd.Next(1, 41);
                        int check = Array.IndexOf(numerot, temp);
                        while (check >= 0)
                        {
                            rnd = new Random();
                            temp = rnd.Next(1, 41);
                            check = Array.IndexOf(numerot, temp);
                        }
                        numerot[j] = temp;

                    }

                    for (int j = 0; j < numerot.Length; j++)
                    {
                        Array.Sort(numerot);
                        Console.Write(numerot[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}