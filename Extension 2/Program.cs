using Double_Linked_List_Class.DS;
namespace Extension_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsDblLinkedList<int> myDblLinkedList = new clsDblLinkedList<int>();

            if (myDblLinkedList.IsEmpty())
            {
                Console.WriteLine("\nYes List is Empty.");
            }
            else
            {
                Console.WriteLine("\nNo List is not Empty.");
            }

            myDblLinkedList.InsertAtBeginning(5);
            myDblLinkedList.InsertAtBeginning(4);
            myDblLinkedList.InsertAtBeginning(3);
            myDblLinkedList.InsertAtBeginning(2);
            myDblLinkedList.InsertAtBeginning(1);

            Console.WriteLine("\nLinked List Content:");
            myDblLinkedList.PrintList();

            Console.WriteLine("\nNumber of items in list = " + myDblLinkedList.Size);

            if (myDblLinkedList.IsEmpty())
            {
                Console.WriteLine("\nYes List is Empty.");
            }
            else
            {
                Console.WriteLine("\nNo List is not Empty.");
            }

        }
    }
}