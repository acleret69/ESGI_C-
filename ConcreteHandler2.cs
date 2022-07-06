namespace ESGI_C_;

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 1000 && request < 2500)
        {
            Console.WriteLine("{0} le chef de cuisine doit obtenir l'approbation du responsable des achats",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}