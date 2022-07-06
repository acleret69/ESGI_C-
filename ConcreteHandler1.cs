namespace ESGI_C_;

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 1000)
        {
            Console.WriteLine("{0} Le chef cuisinier a l'autorisation",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}