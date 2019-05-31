namespace Exercise
{
    public class BuyABook
    {
        public void ShowWorkflow(IWorkflow step)
        {
            step.Execute();
        }
    }
}