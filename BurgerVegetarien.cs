namespace ESGI_C_;

public class BurgerVegetarien : Burger
{
    public BurgerVegetarien(string nom, string temps, int température, string typeCuisson) : base( nom,  temps,  température,  typeCuisson)
    {

    }

    public override void afficherRecette()
    {
        Console.WriteLine("Recette burger Végétarien : ");
        Console.WriteLine("Nom : " + nom);
        Console.WriteLine("temps de cuisson : " + temps);
        Console.WriteLine("Le type de cuisson pour faire cuire l'hamburger est au  : " + typeCuisson);
        Console.WriteLine("Il faut que la température soit de : " + température);
        Console.WriteLine("-----------------------------------------------");

    }

}