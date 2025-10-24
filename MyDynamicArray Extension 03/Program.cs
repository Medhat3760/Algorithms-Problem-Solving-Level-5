using MyDynamicArray.DS;
namespace MyDynamicArray_Extension_03
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

            myDynamicArray.DeleteItemAt(2);

            Console.WriteLine("\nArray items after deleting item(2):");
            Console.WriteLine("\nArray size : " + myDynamicArray.Size);
            myDynamicArray.PrintArray();

            Console.ReadKey();

        }
    }
}