using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_Final_1_2
{
    internal class Program
    {
        //MyStack class for question #1 of the final exam
        public class MyStack
        {
            //Create the stack
            public List<int> stack = new List<int>();

            //Pushes an int onto the stack
            public void Push(int n)
            {
                stack.Add(n);
            }

            //Returns the int at the top of the stack, or null if the stack is empty
            public int? Peek()
            {
                if (stack.Count > 0)
                {
                    return stack[stack.Count - 1];
                }
                else
                {
                    return null;
                }
            }

            //Removes and returns the int at the top of the stack, or returns null if the stack is empty
            public int? Pop()
            {
                if (stack.Count > 0)
                {
                    int? n = stack[stack.Count - 1];
                    stack.Remove(stack.Count - 1);
                    return n;
                }
                else
                {
                    return null;
                }
            }
        }

        //MyQueue class for question #2 of the final exam
        public class MyQueue
        {
            //Create the queue
            public List<int> queue = new List<int>();

            //Adds an int to the front of the queue
            public void Enqueue(int n)
            {
                queue.Insert(0, n);
            }

            //Returns the int at the front of the queue, or null if the queue is empty
            public int? Peek()
            {
                if (queue.Count > 0)
                {
                    return queue[0];
                }
                else
                {
                    return null;
                }
            }

            //Removes and returns the int at the front of the queue, or returns null if the queue is empty
            public int? Dequeue()
            {
                if (queue.Count > 0)
                {
                    int? n = queue[0];
                    queue.RemoveAt(0);
                    return n;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
