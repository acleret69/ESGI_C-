namespace ESGI_C_;

public class Client
{
    public static int vehicule = 3;
    static void Main(string[] args)
    {
        //  création du premier menu et du premier restaurant 
        Menu menu1 = Menu.Instance();
        Restaurant restaurant1 = new Restaurant("Boccuse Lyon 1", menu1);
        
        // créations des repas avec le pattern abstract Factory  
        Repas repas1 = new RepasVegetarien();
        Burger burger1 = repas1.creerBurger("bigMac","10 minutes",150,"four");
        menu1.AjouterPlat(burger1);
        
        Repas repas2 = new RepasViande();
        Burger burger2 = repas2.creerBurger("bigMac poulet","15 minutes",160,"poêle");
        menu1.AjouterPlat(burger2);
        
        restaurant1.AfficherMenu();
        
        //  création du deuxième menu et du deuxième restaurant 
        Menu menu2 = Menu.Instance();
        Restaurant restaurant2 = new Restaurant("Boccuse Lyon 3", menu2);
        
        //vérification Pattern Singleton
        restaurant2.AfficherMenu();
        
        // créations de d'autre repas avec le pattern abstract Factory
        Repas repas3 = new RepasVegetarien();
        Pizza pizza1 = repas3.creerPizza("Pizza chèvre miel","10 minutes",150,"four");
        menu2.AjouterPlat(pizza1);

        Repas repas4 = new RepasViande();
        Pizza pizza2 = repas4.creerPizza("spécial pizza poulet","15 minutes",160,"poêle");
        menu2.AjouterPlat(pizza2);
        
        // Deuxième vérification Pattern Singleton
        restaurant1.AfficherMenu();
        restaurant2.AfficherMenu();

    }
}