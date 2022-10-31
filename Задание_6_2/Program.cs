using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strStart = str.ToLower().Replace(" ", "");
            int i = 0;
            int flag = strStart.Length;

            for (i = 0; (i < (strStart.Length - 1)); i++)
            {
                if (strStart[i] != strStart[strStart.Length - 1 - i])
                {
                    Console.WriteLine("Строка не является палиндромом");
                    break;
                }
                else
                {
                    flag -- ;
                }
            }
            if (flag == 1)
            { Console.WriteLine("Строка является палиндромом"); }
            Console.ReadKey();
        }
    }
}
