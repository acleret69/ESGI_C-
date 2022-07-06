namespace ESGI_C_;

public abstract class Burger
{
    protected string nom { get; set; }
    protected string temps{ get; set; }
    protected int température{ get; set; }
    protected string typeCuisson { get; set; }

    public Burger(string nom, string temps, int température, string typeCuisson)
    {
        this.nom = nom;
        this.temps = temps;
        this.température = température;
        this.typeCuisson = typeCuisson;
    }

    public abstract void afficherRecette();
    
}