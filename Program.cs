using System;
using System.Collections.Generic;
using Hand.ContentContext;

namespace Hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            //Suponha que o usuario colocou as informações do seu livro. para iniciar a progressão.
            articles.Add(new Article("Algoritmos Estruturas, Harry Farrer", "Programação Estruturada"));
            articles.Add(new Article("Programando para processadores paralelos, Kirk Kwu", "Programação GPU"));
            articles.Add(new Article("Enciclopédia da Nuvem, Luli Radfharer", "Conceitos & atualidades"));

            foreach (var article in articles)
            {
                System.Console.WriteLine(article.Id);
                System.Console.WriteLine(article.Title);
                System.Console.WriteLine(article.Url);
            }
            
        }
    }
}