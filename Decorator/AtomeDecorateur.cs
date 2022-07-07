using System;

public class AtomeDecorateur : Decorateur
{
  public AtomeDecorateur(IMolecule
    composant) : base(composant){}

  protected void afficheAtome()
  {
    Console.WriteLine("Une molécule contient un groupe d'atomes mais que contient les atomes ? ");
  }

  public override void affiche()
  {
    base.affiche();
    this.afficheAtome();
  }
}
