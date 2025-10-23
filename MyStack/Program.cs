using MyStack.DS;
namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsMyStack<int> myStack = new clsMyStack<int>();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);

            Console.WriteLine("\nStack:");
            myStack.Print();

            Console.WriteLine("\nStack Size: " + myStack.Size());
            Console.WriteLine("Stack Top: " + myStack.Top());
            Console.WriteLine("Stack Bottom: " + myStack.Bottom());

            myStack.Pop();
            Console.WriteLine("\nStack after pop:");
            myStack.Print();

            //Extension #1
            Console.WriteLine("\nItem(2) : " + myStack.GetItem(2));

            //Extension #2
            myStack.Reverse();
            Console.WriteLine("\nStack after Reverse:");
            myStack.Print();

            //Extension #3
            myStack.UpdateItem(2, 600);
            Console.WriteLine("\nStack after Updating Item(2) to 600:");
            myStack.Print();

            //Extension #4
            myStack.InsertAfter(2, 800);
            Console.WriteLine("\nStack after Inserting 800 after Item(2):");
            myStack.Print();

            //Extension #5
            myStack.InsertAtFront(1000);
            Console.WriteLine("\nStack after Inserting 1000 at front:");
            myStack.Print();

            //Extension #6
            myStack.InsertAtBack(2000);
            Console.WriteLine("\nStack after Inserting 2000 at Back:");
            myStack.Print();

            myStack.Clear();
            Console.WriteLine("\nStack after Clear:");
            myStack.Print();
        }
    }
}