using System;

public class AtomeDecorateur : Decorateur
{
  public AtomeDecorateur(IMolecule
    composant) : base(composant){}

  protected void afficheAtome()
  {
    Console.WriteLine("Informations des atomes");
  }

  public override void affiche()
  {
    base.affiche();
    this.afficheAtome();
  }
}
