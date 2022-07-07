using System;

public class ElectronDecorateur : Decorateur
{
  public ElectronDecorateur(IMolecule
    composant) : base(composant){}

  protected void afficheElectron()
  {
    Console.WriteLine("Electron de la molécule");
  }

  public override void affiche()
  {
    base.affiche();
    this.afficheElectron();
  }
}
