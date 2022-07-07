using System;

public class ElectronDecorateur : Decorateur
{
  public ElectronDecorateur(IMolecule
    composant) : base(composant){}

  protected void afficheElectron()
  {
    Console.WriteLine("Les atomes contient plusieurs choses comme les électrons mais que possédes les électrons ? ");
  }

  public override void affiche()
  {
    base.affiche();
    this.afficheElectron();
  }
}
