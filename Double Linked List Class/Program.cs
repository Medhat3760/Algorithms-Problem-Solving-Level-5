using Double_Linked_List_Class.DS;
namespace Double_Linked_List_Class
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

            clsDblLinkedList<int>.Node n1 = myDblLinkedList.Find(2);

            if(n1 != null)
            {
                Console.WriteLine("\nNode with value 2 is found :-)");
            }
            else
            {
                Console.WriteLine("\nNode with value 2 is NOT found :-(");
            }

            myDblLinkedList.InsertAfter(n1, 500);
            Console.WriteLine("\nAfter inserting 500 after 2:");
            myDblLinkedList.PrintList();

            myDblLinkedList.InsertAtEnd(700);
            Console.WriteLine("\nAfter inserting 700 at end:");
            myDblLinkedList.PrintList();

            clsDblLinkedList<int>.Node n2 = myDblLinkedList.Find(4);

            myDblLinkedList.DeleteNode(ref n2);
            Console.WriteLine("\nAfter Deleting 4:");
            myDblLinkedList.PrintList();

            myDblLinkedList.DeleteFirstNode();
            Console.WriteLine("\nAfter Delete First Node:");
            myDblLinkedList.PrintList();

            myDblLinkedList.DeleteLastNode();
            Console.WriteLine("\nAfter Delete Last Node:");
            myDblLinkedList.PrintList();

            Console.ReadKey();

        }
    }
}