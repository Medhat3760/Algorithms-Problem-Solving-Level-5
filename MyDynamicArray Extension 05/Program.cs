using MyDynamicArray.DS;

namespace MyDynamicArray_Extension_05
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

            int index = myDynamicArray.Find(30);

            if(index == -1)
            {
                Console.WriteLine("\nItem is NOT found :-(");
            }
            else
            {
                Console.WriteLine("\n30 is found at index: " + index);
            }

            myDynamicArray.DeleteItem(30);

            Console.WriteLine("\nArray Items after deleting 30:");
            Console.WriteLine("Array Size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();


            Console.ReadKey();

        }
    }
}