using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    public class Operation
    {
       public  Node Tail = null;

        public void Push(Node data)
        {
            if(Tail == null)
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
