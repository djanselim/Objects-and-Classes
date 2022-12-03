using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] pharses =  { "Excellent product."
                    , "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."};
            string[] events = { "Now I feel good."
                    , "I have succeeded with this product."
                    , "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied."
                    , "I feel great!" };
            string[] authors = { "Diana"
                    , "Petya"
                    , "Stella"
                    , "Elena", "Katya"
                    , "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas"
                    , "Sofia", "Plovdiv"
                    , "Varna", "Ruse" };

            Random rnd = new Random();
            int randomIndex = 0;
            string text = String.Empty;
            for (int i = 0; i < n; i++)
            {
                text = $"{pharses[randomIndex = rnd.Next(0, pharses.Length)]} " +
                    $"{events[randomIndex = rnd.Next(0, events.Length)]} " +
                    $"{authors[randomIndex = rnd.Next(0, authors.Length)]} - " +
                    $"{cities[randomIndex = rnd.Next(0, cities.Length)]} ";
                Console.WriteLine(text);
            }
        }
    }
}
