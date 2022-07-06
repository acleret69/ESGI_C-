namespace ESGI_C_;

public class Program
{
    public static void Main(string[] args)
    {
        // Setup Chain of Responsibility
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();
        Handler h4 = new ConcreteHandler4();
        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);
        h3.SetSuccessor(h4);
        // Generate and process request
        int[] requests = { 5000, 500, 11000, 1890};
        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }
        // Wait for user
        Console.ReadKey();
    }
}