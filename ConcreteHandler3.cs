namespace ESGI_C_;

public class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 2500 && request < 10000)
        {
            Console.WriteLine("{0} chef cuisinier doit obtenir l'approbation du directeur général",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}