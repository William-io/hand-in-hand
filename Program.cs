using System;
using Hand.ContentContext;

namespace Hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var course = new CourseBook();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            
            foreach(var item in course.Modules)
            {
                
            }
            if (course.Level == ContentContext.Enums.EContentLevel.Beginner)
            {
                System.Console.WriteLine($"Que ótimo você inicio os Estudos");
            }
            Console.ReadLine();
        }
    }
}