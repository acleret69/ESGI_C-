namespace ESGI_C_;

public class Program
{
    public static void Main(string[] args)
    {
        Handler h1 = new ChefDeCuinsineHandler();
        Handler h2 = new ResponsableHandler();
        Handler h3 = new DirecteurHandler();
        Handler h4 = new ReunionHandler();
        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);
        h3.SetSuccessor(h4);

        int[] requests = { 5000, 500, 11000, 1890};
        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }

        Console.ReadKey();
    }
}