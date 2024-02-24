using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        string word = "";
        do
        {
            Console.WriteLine("Enter a number:");
            word = Console.ReadLine();
            if (int.TryParse(word, out num))
            {
                if (num < 0) Console.WriteLine("Invalid number: " + num);

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid number: " + word);
                num = 1;
            }
        } while (num != 0);

        Console.WriteLine("Closing Program... ");
    }

}