using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30); 
            stack.Push(56);

            foreach(var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n Top of stack : {0}",stack.Peek());
        }
    }
}
