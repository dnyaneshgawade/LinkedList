using System;

namespace Data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            int a = list.Search(56);
            list.InsertAtParticularPosition(a+1, 30);
            list.Display();
        }
    }
}
