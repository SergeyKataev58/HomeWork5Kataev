using System;

namespace HomeWork5Kataev
{

   // class Check
   // {
        //string login = "";
        //public void CheckLog()
        //{
        //    Console.Write("Введите логин: ");
        //    bool checkEnter = false;
        //    do
        //    {


        //        string source = Console.ReadLine(); ;


        //        if (source.Length < 2 || source.Length > 10)  // Проверка на длину
        //        {
        //            Console.WriteLine("Неверный логин");
        //        }


        //        else if (Char.IsDigit(source[0]))   // Проверка первого символа на цифру
        //        {
        //            Console.WriteLine("Не должен начинаться с цифры");
        //        }
        //        else
        //        {
        //            foreach (char ch in source)
        //            {
        //                if (
        //               (ch < '0') ||
        //               (ch > '9' && ch < 'A') ||
        //               (ch > 'Z' && ch < 'a') ||
        //               (ch > 'z')
        //               )
        //                {
        //                    Console.WriteLine("Не верный символ в логине, разрешены только латинские символы и цифры.");
        //                    break;
        //                }
        //                else
        //                    login = source;
        //                    checkEnter = true;
        //            }
        //        }

                

        //    }
        //    while (!checkEnter);
        //    Console.WriteLine("Логин:" + login);
        //}

   // }
    class Program
    {
        static void Main(string[] args)
        {

            string login = "";


            Console.Write("Введите логин: ");
            bool checkEnter = false;
            NewMethod(ref login, ref checkEnter);
        }

        private static void NewMethod(ref string login, ref bool checkEnter)
        {
            do
            {


                string source = Console.ReadLine(); ;


                if (source.Length < 2 || source.Length > 10)  // Проверка на длину
                {
                    Console.WriteLine("Неверный логин");
                }


                else if (Char.IsDigit(source[0]))   // Проверка первого символа на цифру
                {
                    Console.WriteLine("Не должен начинаться с цифры");
                }
                else
                {
                    foreach (char ch in source)
                    {
                        if (
                       (ch < '0') ||
                       (ch > '9' && ch < 'A') ||
                       (ch > 'Z' && ch < 'a') ||
                       (ch > 'z')
                       )
                        {
                            Console.WriteLine("Не верный символ в логине, разрешены только латинские символы и цифры.");
                            break;
                        }
                        else
                            login = source;
                        checkEnter = true;
                    }
                }



            }
            while (!checkEnter);
            Console.WriteLine("Логин:" + login);
        }
    }
}

