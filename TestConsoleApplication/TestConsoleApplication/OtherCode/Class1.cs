using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SCG = System.Collections.Generic;

namespace TestConsoleApplication
{
    class Item 
    {
        public System.DateTime DateValue {get; set;}
        public System.DateTime TimeValue {get; set;}
        public System.TimeSpan TimeInterval {get; set;}

        public Item(DateTime date)
        {
            this.DateValue = date;
        }
    }

    class ItemComparer : SCG.IComparer<Item>
    {
        int IComparer<Item>.Compare(Item x, Item y)
        {
            return 0;
        }
    }


    static class MainClass
    {
        public static void MainMethod()
        {
            
        }

        public static void PrintList(IEnumerable collection)
        {
            Console.Write("\n");

            bool first = true;
            foreach (object element in collection)
            {
                if (!first)
                {
                    Console.Write(',');
                }
                else
                {
                    first = false;
                }
                Console.Write("[{0}]", element);
            }
            Console.Write("\n");
        }
    }
}
