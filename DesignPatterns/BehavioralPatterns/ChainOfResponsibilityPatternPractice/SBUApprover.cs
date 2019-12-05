using System;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPatternPractice
{
    public class SBUApprover : Approver
    {
        public override void ApproveTicket(Ticket ticket)
        {
            if(ticket.CostCenter == "BusinessUnit")
            {
                Console.WriteLine("{0} approved request for {1}", this.GetType().Name, ticket.TicketNumber);
            }
            else if(_successor != null)
            {
                SetNextApprover(_successor);
            }
        }
    }
}
