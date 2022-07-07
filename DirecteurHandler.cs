namespace ESGI_C_;

public class DirecteurHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 2500 && request < 10000)
        {
            Console.WriteLine("{0} : le chef cuisinier doit obtenir l'approbation du directeur général pour la somme de {1} €",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}