namespace ESGI_C_;

public class Menu
{
    private static Menu _instance = null;

    public int nbVente { get; set; }

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