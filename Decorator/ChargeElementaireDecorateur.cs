namespace ESGI_C_.Decorator;

public class ChargeElementaireDecorateur : Decorateur
{
    public ChargeElementaireDecorateur(IMolecule
        composant) : base(composant){}

    protected void afficheChargeElementaire()
    {
        Console.WriteLine("Les électron posséde une charge élementaire de signe négatif ");
    }

    public override void affiche()
    {
        base.affiche();
        this.afficheChargeElementaire();
    }
}