using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            FullEmployee Tanaka = new NewEmployee();
            NewEmployee Dylan = new NewEmployee();
            Console.WriteLine(Dylan.Benefits());
            Console.WriteLine(Tanaka.Benefits());
        }
    }
}
