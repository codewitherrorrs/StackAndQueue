using System.Collections;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue(56);
            q1.Enqueue(30);
            q1.Enqueue(70);

            foreach (var i in q1)
            {
                Console.WriteLine("Before Dequeue : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}",q1.Peek());
            Console.WriteLine("************************");

          /*  q1.Dequeue();

            foreach (var i in q1)
            {
                Console.WriteLine("After Dequeue : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");

            q1.Dequeue();

            foreach (var i in q1)
            {
                Console.WriteLine("After Dequeue : " + i);
            }
            Console.WriteLine("\nTop of the stack : {0}", q1.Peek());
            Console.WriteLine("************************");

            q1.Dequeue();
            Console.WriteLine("Queue Was Empty"); */


        }

    }
}
