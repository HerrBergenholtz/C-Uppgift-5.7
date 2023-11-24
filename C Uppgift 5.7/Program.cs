using System;

class Program
{
    public static void Main()
    {
        string[] länder = { "Kina", "Indien", "USA", "Indonesien", "Pakistan" };
        
        for (int i = 0; i < länder.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {länder[i]}");
        }

        try
        {
            Console.WriteLine("Vilka länder vill du ska visas igen? (skriv in landens siffror separerat av mellanslag");
            string[] input = Console.ReadLine().Split(" ");
            int[] nummer = new int[input.Length];

            for (int i = 0;i < input.Length;i++)
            {
                nummer[i] = int.Parse(input[i]) - 1;
            }
        
            for (int i = 0; i < nummer.Length ; i++) 
            {
                Console.WriteLine($"{nummer[i] + 1}. {länder[nummer[i]]}");
            }
        }

        catch
        {
            Console.WriteLine("Fel input, vänligen pröva igen");
            Console.ReadKey();
            Main();
        }
    }
}