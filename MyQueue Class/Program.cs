using MyQueue_Class.DS;
namespace MyQueue_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsMyQueue<int> myQueue = new clsMyQueue<int>();

            myQueue.Push(10);
            myQueue.Push(20);
            myQueue.Push(30);
            myQueue.Push(40);
            myQueue.Push(50);

            Console.WriteLine("\nQueue:");
            myQueue.Print();

            Console.WriteLine("\nQueue Size: " + myQueue.Size());
            Console.WriteLine("Queue Front: " + myQueue.Front());
            Console.WriteLine("Queue Back: " + myQueue.Back());

            myQueue.Pop();

            Console.WriteLine("\nQueue After Pop:");
            myQueue.Print();

        }
    }
}