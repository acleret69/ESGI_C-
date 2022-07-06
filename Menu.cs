namespace ESGI_C_;

public class Menu
{
    private static Menu _instance = null;

     public int nbRepas;
    /*public List<dynamic> burgerViandesList { get; set; }
    public List<dynamic> burgerVegetarienList { get; set; }
    public List<dynamic> pizzaViandesList { get; set; }
    public List<dynamic> pizzaVegetarienList { get; set; }*/

    private Menu()
    {
    }

    public static Menu Instance()
    {
        if (_instance == null)
            _instance = new Menu();
        return _instance;
    }
}