namespace ESGI_C_;

public interface Repas
{
    Burger creerBurger(string nom, string temps, int température, string typeCuisson);
    
    Pizza creerPizza(string nom, string temps, int température, string typeCuisson);

}