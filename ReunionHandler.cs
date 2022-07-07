namespace ESGI_C_;

public class ReunionHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10000 )
        {
            Console.WriteLine("{0} : le directeur général convoquera une réunion de l'exécutif pour déterminer s'il doit effectuer l'achat demandé vu que la somme est de : {1} €",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}