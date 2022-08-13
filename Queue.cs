using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue
    {
        public static void CreateQueue()
        {
            Console.WriteLine("Insert data using queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);


            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("After Dequeue ");
            queue.Dequeue();

            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
