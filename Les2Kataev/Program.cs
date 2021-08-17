using System;
using System.Linq;

namespace Les2Kataev
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string s1 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите вторуя строку: ");
            string s2 = Convert.ToString(Console.ReadLine());
            NewMethod(s1, s2);
        }

        private static void NewMethod(string s1, string s2)
        {
            if (

                        s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x))
                           )
                Console.WriteLine("Символы в строках одинаковые");
            else
                Console.WriteLine("Символы в строках различны");
        }
    }
}
