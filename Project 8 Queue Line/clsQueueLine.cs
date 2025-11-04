using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MyLib;

namespace Project_8_Queue_Line
{
    public class clsQueueLine
    {

        private short _totalTickets = 0;
        private string _prefix = "";
        private short _averageServeTime = 0;

        class clsTicket
        {

            private string _prefix;
            private short _number = 0;
            private int _watingClients = 0;
            private string _ticketTime = "";
            private short _averageServeTime = 0;
            private short _expectedServeTime = 0;

            public clsTicket(string prefix, short number, int waitingClients, short averageServeTime)
            {
                _prefix = prefix;
                _number = number;
                _watingClients = waitingClients;
                _ticketTime = clsDate.GetSystemDateTimeString();
                _averageServeTime = averageServeTime;
            }

            public string Prefix
            {
                get
                {
                    return _prefix;
                }
            }

            public short Number
            {
                get
                {
                    return _number;
                }
            }

            public string FullNumber()
            {
                return _prefix + _number.ToString();
            }

            public int WatingClients => _watingClients;

            public string TicketTime => _ticketTime;


            public short ExpectedServeTime
            {

                get
                {
                    _expectedServeTime = (short)(_averageServeTime * _watingClients);
                    return _expectedServeTime;
                }

            }

            public void Print()
            {

                Console.WriteLine("\t\t\t\t ___________________________________");
                Console.WriteLine("\n\t\t\t\t\t\t" + FullNumber());
                Console.WriteLine("\n\t\t\t\t\t" + TicketTime);
                Console.WriteLine("\t\t\t\t\tWating Clients = " + _watingClients);
                Console.WriteLine("\t\t\t\t\t  Serve Time In");
                Console.WriteLine("\t\t\t\t\t    " + ExpectedServeTime.ToString() + " Minutes.");
                Console.WriteLine("\t\t\t\t ___________________________________\n");

            }

        }

        private Queue<clsTicket> _queueLine = new Queue<clsTicket>();

        public clsQueueLine(string prefix, short averageServeTime)
        {

            _prefix = prefix;
            _averageServeTime = averageServeTime;
            _totalTickets = 0;

        }

        public void IssueTicket()
        {

            _totalTickets++;

            clsTicket ticket = new clsTicket(_prefix, _totalTickets, WaitingClients(), _averageServeTime);

            _queueLine.Enqueue(ticket);

        }

        public int WaitingClients()
        {

            return _queueLine.Count;

        }

        public string WhoIsNext()
        {

            if (_queueLine.Count == 0)
            {
                return "No Clients Left.";
            }

            return _queueLine.Peek().FullNumber();

        }

        public bool ServeNextClient()
        {

            if (_queueLine.Count == 0)
            {
                return false;
            }

            _queueLine.Dequeue();
            return true;

        }

        public short ServedClients()
        {

            return (short)(_totalTickets - WaitingClients());

        }

        public void PrintInfo()
        {

            Console.WriteLine("\n\t\t\t\t___________________________________");
            Console.WriteLine("\n\t\t\t\t\t    Queue Info");
            Console.WriteLine("\t\t\t\t___________________________________");

            Console.WriteLine("\n\t\t\t\t\tPrefix         = " + _prefix);
            Console.WriteLine("\t\t\t\t\tTotal Tickets  = " + _totalTickets);
            Console.WriteLine("\t\t\t\t\tServed Clients = " + ServedClients());
            Console.WriteLine("\t\t\t\t\tWating Clients = " + WaitingClients());

            Console.WriteLine("\t\t\t\t___________________________________");

        }

        public void PrintTicketsLineRTL()
        {

            if (_queueLine.Count == 0)
            {

                Console.WriteLine("\n\n\t\t\tTickets: No Tickets.");
                return;

            }

            Console.Write("\n\n\t\t\t Tickets:  ");

            foreach (clsTicket ticket in _queueLine)
            {
                Console.Write(" " + ticket.FullNumber() + " <-- ");
            }

            Console.WriteLine();

        }

        public void PrintTicketsLineLTR()
        {

            if (_queueLine.Count == 0)
            {

                Console.WriteLine("\n\t\t\t Tickets: No Tickets.");
                return;

            }

            Stack<clsTicket> stack = new Stack<clsTicket>(_queueLine);

            Console.Write("\n\t\t\t Tickets:  ");

            foreach (clsTicket ticket in stack)
            {
                Console.Write(" " + ticket.FullNumber() + " --> ");
            }

            Console.WriteLine();

        }

        public void PrintAllTickets()
        {

            Console.WriteLine("\n\n\t\t\t\t\t     --Tickets--");

            if (_queueLine.Count == 0)
            {
                Console.WriteLine("\n\n\t\t\t     ---No Tickets---\n");
                return;
            }

            foreach (clsTicket ticket in _queueLine)
            {
                ticket.Print();
            }

        }

    }
}
