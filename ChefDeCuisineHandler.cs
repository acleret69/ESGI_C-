namespace ESGI_C_;

public class ChefDeCuinsineHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 1000)
        {
            Console.WriteLine("{0} : Le chef cuisinier a l'autorisation pour la somme de {1} €",
                this.GetType().Name, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}