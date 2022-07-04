using System;

public abstract class Automobile
{
    protected string modele;
    protected string couleur;
    protected int puissance;
    protected double espace;

    public Automobile(string modele, string couleur, int puissance, double espace)
    {
        this.modele = modele;
        this.couleur = couleur;
        this.puissance = puissance;
        this.espace = espace;
    }

    public abstract void afficherCarac();


    //----------------------------------------------------------------------------------------------------

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


    public interface FabriqueVehicule
    {
        Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);

    }

    public class FabriqueAutomobileElectrique : FabriqueVehicule
    {
        public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectrique(modele, couleur, puissance, espace);
        }
    }

    public class Catalogue
    {

        public static int vehicule = 3;
        static void Main(string[] args)
        {
            FabriqueVehicule fabrique = new FabriqueAutomobileElectrique();
            Automobile auto = fabrique.creerAutomobile("Tesla", "Bleu", 250, 2.5);
            auto.afficherCarac();
        }
    }




}