namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class TeamLead : ILead, IProgrammer
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }

        public void WorkOnTask()
        {
        }
    }
}
