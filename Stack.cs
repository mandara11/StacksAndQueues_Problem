using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        public static void CreateStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
