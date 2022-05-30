using System;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {
            string FullName = "Петров Иван Иванович";
            int Age = 18;
            string email = "Petrov1996@gmail.com";
            double Program_Scores = 78.5;
            double Math_Scores = 98;
            double Physics_Scores = 85;

            string pattern = "Ф.И.О.: {0} \nВозраст: {1} \nemail: {2} \nБаллы по программированию {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            Console.WriteLine(pattern,
                              FullName,
                              Age,
                              email,
                              Program_Scores,
                              Math_Scores,
                              Physics_Scores);
            Console.ReadKey();








        }






    }









}





















