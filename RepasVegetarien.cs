namespace ESGI_C_;

public class RepasVegetarien : Repas
{
    public Burger creerBurger(string nom, string temps, int température, string typeCuisson)
    {
        return new BurgerVegetarien(nom, temps, température, typeCuisson);
    }
    
    public Pizza creerPizza(string nom, string temps, int température, string typeCuisson)
    {
        return new PizzaVegetarien(nom, temps, température, typeCuisson);
    }
}