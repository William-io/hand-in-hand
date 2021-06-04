using System;
using System.Collections.Generic;
using System.Linq;
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

            var authors = new List<Author>();
            var careerDotnet = new Author("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new AuthorItem(2, "Aprenda OOP", "", null);
            var careerItem = new AuthorItem(1, "Comece por aqui", "", null);
            var careerItem3 = new AuthorItem(3, "Aprenda .NET", "", null);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            authors.Add(careerDotnet);

            foreach (var career in authors)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.courseBook?.Title);
                    Console.WriteLine(item.courseBook?.Level);
                }
            }

            foreach (var article in articles)
            {
                System.Console.WriteLine(article.Id);
                System.Console.WriteLine(article.Title);
                System.Console.WriteLine(article.Url);
            }
            
        }
    }
}