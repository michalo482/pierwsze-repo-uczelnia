using System;

namespace pierwsze_repo_uczelnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imie:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
            Console.WriteLine("Podaj swoj wiek:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 60)
            {
               Console.WriteLine("jestes na emeryturze " + userName); 
            } 
            else
            {
                int left = 60 - age;
                Console.WriteLine("do emerytury zostalo ci: " + left);
            }
        }
    }
}
