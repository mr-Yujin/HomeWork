using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class HomeWork1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("Пажалуйста введите число или нажмите q для выхода из программы");

            string S = Console.ReadLine();
            /*Ниже я не совсем понял зачем нужна эта функция, если о ней нет никикой информации
             * для конечного пользователя. Поэтому сверху добавил информацию для понимания 
             * "или нажмите q для выхода из программы"
             */
            if (S == "q")
            {
                return;
            }
            
            int M = int.Parse(S);
            int c1 = 1; 
            int c2 = 0;
            int c3 = 0;
            
            for (int i = 1; i <= M; i++)
            {
                //Ниже я сократил формулы из того что предложила Студия
                c1 *= i;
                c2 += i;
                if (i % 2 == 0)
                {
                    c3 = i;
                }
            }
            
            Console.WriteLine("Факториал равет " + c1); 
            
            Console.WriteLine("Сума от 1 до N равна " + c2);

            Console.WriteLine("максимальное четное число меньше N равно " + c3);
            Console.ReadLine();
        }
    }
}
