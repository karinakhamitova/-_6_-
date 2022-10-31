using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strStart = Console.ReadLine();
            string[] strArr = strStart.Split(); 
            string maxStr = strArr[0];
            foreach (string str in strArr)
            {
                if (str.Length > maxStr.Length)
                { 
                    maxStr = str;   
                }
            }
            Console.WriteLine(maxStr);  
            Console.ReadKey(); 
        }
    }
}
