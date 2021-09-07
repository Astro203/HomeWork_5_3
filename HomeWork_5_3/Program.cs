using System;

namespace HomeWork_5_3
{
    class Program
    {
        /// <summary>
        /// метод возвращающий строку без одинаковых рядом стоящих символов
        /// </summary>
        /// <param name="stroka"></param>
        /// <returns></returns>
        static string stringHandlingMethod(string stroka)
        {
            stroka = stroka.ToLower();
            string newStroka = "";
            if (stroka.Length > 0)
            {          
                char stringSimbol = ' ';
                int i = 0;
                while (i < stroka.Length)
                {
                    if (stringSimbol == stroka[i]) i++;
                    else
                    {
                        stringSimbol = stroka[i];
                        newStroka += stroka[i];
                    }
                    i++;
                }
            }
            return newStroka;
        }
        static void Main(string[] args)
        {
            //Задание 3. Создание метода, принимающего строку и возвращающего новую строку, в которой удалены все рядом стоящие повторяющиеся символы

            Console.Write("Введите строку: "); string stroka = Console.ReadLine(); //ввод строки
            Console.WriteLine();
            Console.WriteLine($"{stroka} >>> {stringHandlingMethod(stroka)}"); //вывод полученной строки
        }
    }
}
