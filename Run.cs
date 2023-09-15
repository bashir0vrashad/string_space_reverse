using System;

namespace ConsoleApp1
{
    delegate void Func(string b);
    internal class Run
    {   public void runFunc(Func a , string b)
        {
            foreach (var item in a.GetInvocationList())
            {
                item.DynamicInvoke(b);
            }
        }
        public Run() { }
    }
}
