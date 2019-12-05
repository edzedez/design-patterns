using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.FacadePatternPractice
{
    public class FacadePractice
    {
        private ITAMFunctions itamFunctions;
        private My1Functions my1Functions;
        private KasyaUserFunctions kasyaUserFunctions;

        public FacadePractice()
        {

        }

        public void DoServiceDeskTask()
        {
            itamFunctions.SaveAssets();
            my1Functions.SolveTickets();
        }

        public void Automation()
        {
            kasyaUserFunctions.EnableAutomation();
        }
    }

    public class MainApp
    {
        public static void Main()
        {
            var facade = new FacadePractice();

            facade.DoServiceDeskTask();
            facade.Automation();
        }
    }
}