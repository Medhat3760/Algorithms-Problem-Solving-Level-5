namespace Project_8_Queue_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsQueueLine payBillsQueue = new clsQueueLine("A0", 10);
            clsQueueLine subscriptionsQueue = new clsQueueLine("B0", 5);

            payBillsQueue.IssueTicket();
            payBillsQueue.IssueTicket();
            payBillsQueue.IssueTicket();
            payBillsQueue.IssueTicket();
            payBillsQueue.IssueTicket();

            Console.WriteLine("\nPay Bills Queue Info:");
            payBillsQueue.PrintInfo();

            payBillsQueue.PrintTicketsLineRTL();
            payBillsQueue.PrintTicketsLineLTR();

            payBillsQueue.PrintAllTickets();

            payBillsQueue.ServeNextClient();

            Console.WriteLine("\nPay Bills Queue After serving one client:");
            payBillsQueue.PrintInfo();



            Console.WriteLine("\nSubscriptions Queue Info:");

            subscriptionsQueue.IssueTicket();
            subscriptionsQueue.IssueTicket();
            subscriptionsQueue.IssueTicket();

            subscriptionsQueue.PrintInfo();

            subscriptionsQueue.PrintTicketsLineRTL();
            subscriptionsQueue.PrintTicketsLineLTR();

            subscriptionsQueue.PrintAllTickets();

            subscriptionsQueue.ServeNextClient();

            Console.WriteLine("\nSubsriptions Queue After serving one client:");
            subscriptionsQueue.PrintInfo();

        }
    }
}