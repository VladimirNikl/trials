using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void method()
        {
            Console.WriteLine(" method master");
        }
        static void Main()
        {
            FindAndReplaceManager.book =  new[] { "dsfgbdf" , "rtewt" , "" , "treth" , "rthfh" , "thwrthf" , "bbb"};
            Console.WriteLine(" Введите слово для поиска");
            FindAndReplaceManager.FindNext(Console.ReadLine());

            method();

            Console.ReadKey();
        }
    }
}
     