using Double_Linked_List_Class.DS;
namespace Extension_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsDblLinkedList<int> myDblLinkedList = new clsDblLinkedList<int>();

            myDblLinkedList.InsertAtBeginning(5);
            myDblLinkedList.InsertAtBeginning(4);
            myDblLinkedList.InsertAtBeginning(3);
            myDblLinkedList.InsertAtBeginning(2);
            myDblLinkedList.InsertAtBeginning(1);

            Console.WriteLine("\nLinked List Content:");
            myDblLinkedList.PrintList();

            myDblLinkedList.InsertAfter(1, 500);

            Console.WriteLine("\nAfter Insert:");
            myDblLinkedList.PrintList();

            Console.ReadKey();

        }
    }
}