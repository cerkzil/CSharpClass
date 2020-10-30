using System;

namespace Fibinachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long do you want Fibinachi sequance to go?");
            int b = int.Parse(Console.ReadLine());
            int[] array = new int[b+1];

            if (b > 0) { array[0] = 0; Console.Write(array[0]); }
            if (b > 1) { array[1] = 1; Console.Write(", " + array[1]); }
            if (b >= 2)
            {
                for (int i = 2; i < b; i++)
                {
                    array[i] = array[i - 1] + array[i - 2];
                    Console.Write(", " + array[i]);
                }
            }
        }
    }
}
