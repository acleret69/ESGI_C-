namespace ESGI_C_;

public class Client
{
    public static int vehicule = 3;
    static void Main(string[] args)
    {
        FabriqueVehicule fabrique = new FabriqueAutomobileElectrique();
        Automobile auto = fabrique.creerAutomobile("Tesla", "Bleu", 250, 2.5);
        auto.afficherCarac();
    }
}