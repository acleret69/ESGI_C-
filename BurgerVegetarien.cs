namespace ESGI_C_;

public class AutomobileElectrique : Automobile
{
    public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
    {

    }

    public override void afficherCarac()
    {
        Console.WriteLine("Automobile électrique : ");
        Console.WriteLine("Modele : " + modele);
        Console.WriteLine("couleur : " + couleur);
        Console.WriteLine("puissance : " + puissance);
        Console.WriteLine("espace : " + espace);

    }

}