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
        Console.WriteLine("Voici la liste des repas dans le menu du restaurant "+nom );
        Console.WriteLine("-----------------------------------------------");
        menu.AfficherMenu();
        
    }
}