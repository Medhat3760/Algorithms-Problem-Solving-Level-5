using Double_Linked_List_Class.DS;
namespace Extension_3
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

            Console.WriteLine("\nNumber of items in the linked list = " + myDblLinkedList.Size);

            Console.WriteLine("\nExcuting .Clear()");

            myDblLinkedList.Clear();

            Console.WriteLine("\nNumber of items in the linked list = " + myDblLinkedList.Size);



        }
    }
}