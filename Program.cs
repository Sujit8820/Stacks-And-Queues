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

            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            operation.Enqueu(node1);
            operation.Enqueu(node2);
            operation.Enqueu(node3);

            operation.Display();
            Console.WriteLine("==============");
            operation.Dequeu();
           





        }
    }
}


    


    
