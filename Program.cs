// See https://aka.ms/new-console-template for more information
using System;

namespace Stacks_And_Queues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Stacks and Queues");
            Operation operation = new Operation();

            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            operation.Push(node1);
            operation.Push(node2);
            operation.Push(node3);

            operation.Display();



        }
    }
}


    


    
