using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPatternPractice
{
    //Chain handler
    public abstract class Approver
    {
        protected Approver _successor;

        public void SetNextApprover(Approver successor)
        {
            this._successor = successor;
        }

        public abstract void ApproveTicket(Ticket ticket);
    }
}
