namespace ESGI_C_;

public class FabriqueAutomobileElectrique : FabriqueVehicule
{
    public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileElectrique(modele, couleur, puissance, espace);
    }
}