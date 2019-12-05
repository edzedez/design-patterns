namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPatternPractice
{
    public class Ticket
    {
        private string _ticketNumber;
        private string _assignee;
        private string _costCenter;

        public Ticket(string ticketNumber, string assignee, string costCenter)
        {
            this._ticketNumber = ticketNumber;
            this._assignee = assignee;
            this._costCenter = costCenter;
        }

        public string TicketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }

        public string Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }

        public string CostCenter
        {
            get { return _costCenter; }
            set { _costCenter = value; }
        }

    }
}
