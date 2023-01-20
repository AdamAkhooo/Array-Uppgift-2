using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hur många antal heltal vill du skriva in?");
        int antal = int.Parse(Console.ReadLine());
        string[] heltal = new string[antal];

        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine("skriv in valfri/valfria heltal");
            heltal[i] = Console.ReadLine();

        }

        Console.WriteLine("Här kommer talen du valt visas");
        for (int i = 0; i < antal; i++)
        {
            Console.Write($"tal{i + 1}): {heltal[i]} \n");
        }
    }
}