using System;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibilityPatternPractice
{
    public class MainApp
    {
        public static void Main()
        {
            var sbuApprover = new SBUApprover();
            var pmApprover = new PMApprover();

            sbuApprover.SetNextApprover(pmApprover);

            var ticket = new Ticket("UAR1230123", "bllanto", "BusinessUnit");
            sbuApprover.ApproveTicket(ticket);

            ticket = new Ticket("UAR1230124", "lplatero", "Department");
            pmApprover.ApproveTicket(ticket);

            Console.ReadLine();


        }
    }
}
