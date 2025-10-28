using MyQueueArr.DS;
namespace MyQueueArr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsMyQueueArr<int> myQueue = new clsMyQueueArr<int>();

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

            Console.WriteLine("\n Item(2) : " + myQueue.GetItem(2));

            myQueue.Reverse();
            Console.WriteLine("\nQueue after Reverse :");
            myQueue.Print();

            myQueue.UpdateItem(2, 600);
            Console.WriteLine("\nQueue after updating Item(2) to 600:");
            myQueue.Print();

            myQueue.InsertAfter(2, 800);
            Console.WriteLine("\nQueue after Inserting 800 after Item(2):");
            myQueue.Print();

            myQueue.InsertAtFront(1000);
            Console.WriteLine("\nQueue after Inserting 1000 at front:");
            myQueue.Print();

            myQueue.InsertAtBack(2000);
            Console.WriteLine("\nQueue after Inserting 2000 at back:");
            myQueue.Print();

            myQueue.Clear();
            Console.WriteLine("\nQueue after Clear:");
            myQueue.Print();

            Console.ReadKey();

        }
    }
}