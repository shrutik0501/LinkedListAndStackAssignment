using System;

namespace Day_16_DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2,51);
            list.RemoveFirstNode();
            list.Search(51);
            list.RemoveLastNode();
            list.Display();
        }
    }
}
