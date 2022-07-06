namespace ESGI_C_;

public class RepasViande : Repas
{
    public Burger creerBurger(string nom, string temps, int température, string typeCuisson)
    {
        return new BurgerViandes(nom, temps, température, typeCuisson);
    }
    
    public Pizza creerPizza(string nom, string temps, int température, string typeCuisson)
    {
        return new PizzaViande(nom, temps, température, typeCuisson);
    }
}