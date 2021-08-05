using System;

namespace Data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.RemoveLastNode();
            Console.WriteLine("Linked list after last element deleted");
            list.Display();
        }
    }
}
