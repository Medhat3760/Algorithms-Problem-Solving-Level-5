using MyDynamicArray.DS;

namespace MyDynamicArray_Extension_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsDynamicArray<int> myDynamicArray = new clsDynamicArray<int>(5);

            myDynamicArray.SetItem(0, 10);
            myDynamicArray.SetItem(1, 20);
            myDynamicArray.SetItem(2, 30);
            myDynamicArray.SetItem(3, 40);
            myDynamicArray.SetItem(4, 50);

            Console.WriteLine("\nIs Empty? " + myDynamicArray.IsEmpty());
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            Console.WriteLine("\nArray Items:");
            myDynamicArray.PrintArray();

            myDynamicArray.InsertAtBeginning(400);
            Console.WriteLine("\nArray Items after insert 400 at beginning:");
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();

            myDynamicArray.InsertBefore(2, 500);
            Console.WriteLine("\nArray Items after insert 500 before index 2:");
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();

            myDynamicArray.InsertAfter(2, 600);
            Console.WriteLine("\nArray Items after insert 600 after index 2:");
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();

            myDynamicArray.InsertAtEnd(800);
            Console.WriteLine("\nArray Items after insert 800 at End:");
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();


            Console.ReadKey();

        }
    }
}