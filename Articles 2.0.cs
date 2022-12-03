using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Articels> article = new List<Articels>();
            for (int i = 0; i < n; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                Articels currentArticle = new Articels(currArticle[0], currArticle[1], currArticle[2]);
                article.Add(currentArticle);
            }
            foreach (var art in article)
            {
                Console.WriteLine(art);
            }
        }
    }

    class Articels
    {
        public Articels(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
