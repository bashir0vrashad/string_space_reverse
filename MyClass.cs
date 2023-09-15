using System.Reflection.Metadata;

namespace ConsoleApp1
{
   
    internal class MyClass
    {
        public void Space( string str)
        {
            string yeni="";
            for (int i = 0; i < str.Length; i++)
            {
                yeni += str[i];
                if (i == str.Length - 1)
                {
                    Console.WriteLine(yeni);
                    return;
                }
                yeni += "_";
            }

        }
        public void Reverse( string str) {
            for (int i = str.Length-1; i >=0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        public MyClass() { }

    }
}
