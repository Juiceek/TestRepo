using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    struct Struct2
    {
        //sbyte sbField;

        const ulong MYCONST = 2;
    }


    //---------------------------------
    enum MyEnum : byte
    {
        None = 1,
        A = 2,
        B = 3,
        C = 4
    }

    class TestEnum
    {
        public MyEnum e;
    }
    //----------------------




    struct MyStruct
    {
        internal byte x;
        internal byte y;

        public MyStruct(char c = 'q')
        {
            Console.WriteLine("in the constructor, char c is '{0}' ", c);
            //
            this.x = 1;
            this.y = 1;
        }

        public override string ToString()
        {
            return 
                base.ToString() + " ====== " +
                    String.Format("{{ x={0}, y={1} }}", x, y);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(System.DateTime.Now));
            items.Add(new Item(System.DateTime.Now));
            items.Add(new Item(System.DateTime.Now));

            MainClass.PrintList( items);

            items.Sort();
            
            //--------------------------------------------------
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
