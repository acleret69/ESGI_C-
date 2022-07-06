namespace ESGI_C_;

public class Restaurant
{
     string nom;
     Menu menu;

    public Restaurant(string nom, Menu menu)
    {
        this.nom = nom;
        this.menu = menu;
    }

    public void AfficherMenu()
    {
        Console.WriteLine("le nombre de repas dans le menu du restaurant "+nom+" est de : " + menu.nbRepas);
        Console.WriteLine("-----------------------------------------------");
        
    }
}