using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    public class Operation
    {
        public Node Tail = null;

        public void Push(Node data)
        {
            if (Tail == null)
            {
                Tail = data;
            }
            else
            {
                Node temp = data;
                temp.next = Tail;
                Tail = temp;

            }

        }

        public void PeakAndPop()
        {

            while (Tail != null)
            {
                Node p = Tail;
                Console.WriteLine("\nPeak " + p.data);
                Tail = Tail.next;
                Console.WriteLine("========");
                Display();
            }


        }

        public void Enqueu(Node data)
        {
            if (Tail == null)
            {
                Tail = data;
            }
            else
            {
                Node temp = data;
                Node p = Tail;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = temp;

            }
        }

        public void Dequeu()
        {

            while (Tail != null)
            {
                Tail = Tail.next;
                Display();
                Console.WriteLine("=======");

            }


        }
        public void Display()
        {
            if (Tail == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node p = Tail;

                while (p != null)
                {
                    Console.WriteLine(p.data);
                    p = p.next;
                }
            }
        }
    }
}
