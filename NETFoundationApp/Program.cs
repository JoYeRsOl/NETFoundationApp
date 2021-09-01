using NETFoundationApp_Challenge1;
using System;

namespace NETFoundationApp
{
    
    class Program
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i * 5);
            }
            list.Print();
            list.Insert(5, 420);
            list.Print();
        }
    }
}
