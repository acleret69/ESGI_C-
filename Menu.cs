namespace ESGI_C_;

public class Menu
{
    private static Menu _instance = null;
    
    public List<Object> plats  { get; set; }
    /*public List<dynamic> burgerViandesList { get; set; }
    public List<dynamic> burgerVegetarienList { get; set; }
    public List<dynamic> pizzaViandesList { get; set; }
    public List<dynamic> pizzaVegetarienList { get; set; }*/

    private Menu()
    {
        plats = new List<Object>();
    }

    public static Menu Instance()
    {
        if (_instance == null)
            _instance = new Menu();
        return _instance;
    }

    public void AjouterPlat(Object plat)
    {
        plats.Add(plat);
    }

    public void AfficherMenu()
    {
        foreach (Object plat in plats)
        {
            if (plat.GetType() == typeof(BurgerVegetarien)) 
            {
                ((BurgerVegetarien)plat).afficherRecette();
            }else if (plat.GetType() == typeof(BurgerViandes)) 
            {
                ((BurgerViandes)plat).afficherRecette();
            }else if (plat.GetType() == typeof(PizzaVegetarien)) 
            {
                ((PizzaVegetarien)plat).afficherRecette();
            }else if (plat.GetType() == typeof(PizzaViande)) 
            {
                ((PizzaViande)plat).afficherRecette();
            }
        }
    }
}