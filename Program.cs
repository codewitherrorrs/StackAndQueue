using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30); 
            stack.Push(56);

            foreach (var i in stack)
            {
                Console.WriteLine("Before Pop : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}",stack.Peek());
            Console.WriteLine("********************");
           
            stack.Pop();

            foreach (var i in stack)
            {
                Console.WriteLine("After Pop : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}", stack.Peek());
            Console.WriteLine("********************");

            stack.Pop();

            foreach (var i in stack)
            {
                Console.WriteLine("After Pop : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}", stack.Peek());
            Console.WriteLine("********************");

            stack.Pop();

            foreach (var i in stack)
            {
                Console.WriteLine("After Pop : " + i);
            }
            stack.Pop();
            Console.WriteLine("Stack Was Empty");
            Console.WriteLine("********************");


        }

    }
}
