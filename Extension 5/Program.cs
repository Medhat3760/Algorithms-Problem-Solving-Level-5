using Double_Linked_List_Class.DS;
namespace Extension_5
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

            clsDblLinkedList<int>.Node n;

            n = myDblLinkedList.GetNode(0);

            if(n!= null)
            Console.WriteLine("\nNode value is " + n.value);

        }
    }
}