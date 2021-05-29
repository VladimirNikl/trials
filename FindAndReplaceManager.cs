using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    static class FindAndReplaceManager   // нельзя объявлять индексаторы в статическом классе.
    {
        public static string[] book;
        public static void FindNext(string str)
        {
            for(int i=0; i<book.Length; i++)
            {
                if (book[i] == str)
                {
                    Console.WriteLine("'"+str+"' -" + "  является номером " + i + " в книге .");
                    return;  // return - выход из метода и Console.WriteLine("Нет такого слова в книге.") - не напечатается.
                } 
            }
            Console.WriteLine("Нет такого слова в книге.");
        }

    }
}
