namespace ESGI_C_;

public abstract class Pizza
{
    protected string nom;
    protected string temps;
    protected int température;
    protected string typeCuisson;

    public Pizza(string nom, string temps, int température, string typeCuisson)
    {
        this.nom = nom;
        this.temps = temps;
        this.température = température;
        this.typeCuisson = typeCuisson;
    }

    public abstract void afficherRecette();
    
}