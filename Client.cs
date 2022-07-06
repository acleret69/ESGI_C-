namespace ESGI_C_;

public class Client
{
    public static int vehicule = 3;
    static void Main(string[] args)
    {
        Menu menu1 = Menu.Instance();
        menu1.nbRepas = 10;

        Restaurant restaurant1 = new Restaurant("MacDo", menu1);
        restaurant1.AfficherMenu();
        

        Repas repas1 = new RepasVegetarien();
        Burger burger1 = repas1.creerBurger("bigMac","10 minutes",150,"four");
        burger1.afficherRecette();
        
        Repas repas2 = new RepasViande();
        Burger burger2 = repas1.creerBurger("bigMac poulet","15 minutes",160,"poêle");
        burger2.afficherRecette();
        
        Menu menu2 = Menu.Instance();
        menu2.nbRepas = 12;
        Restaurant restaurant2 = new Restaurant("Pizza Cozy", menu2);
        restaurant1.AfficherMenu();
        restaurant2.AfficherMenu();
        
        Repas repas3 = new RepasVegetarien();
        Pizza pizza1 = repas1.creerPizza("Pizza chèvre miel","10 minutes",150,"four");
        burger1.afficherRecette();
        
        Repas repas4 = new RepasViande();
        Pizza pizza2 = repas1.creerPizza("spécial pizza poulet","15 minutes",160,"poêle");
        burger2.afficherRecette();
        
        



        /*RepasViande repasViande = new RepasViande();
        Burger bigMac = repasViande.creerBurger("bigMac","10 minutes",150,"four");
        RepasVegetarien repasVegetarien = new RepasVegetarien();
        Pizza pizzaChevreMiel = repasVegetarien.creerPizza("pizza chèvre miel","10 minutes",150,"four");
        menu1.burgerViandesList.Add(bigMac);
        menu1.pizzaVegetarienList.Add(pizzaChevreMiel);
        Restaurant restaurant1 = new Restaurant("bigM", menu1);
        restaurant1.AfficherMenu();*/


        /*FabriqueVehicule fabrique = new FabriqueAutomobileElectrique();
        Automobile auto = fabrique.creerAutomobile("Tesla", "Bleu", 250, 2.5);
        auto.afficherCarac();*/
    }
}