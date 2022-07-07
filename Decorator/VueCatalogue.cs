using System;

public class VueCatalogue
{
  static void Main(string[] args)
  {
    VueMolecule vueMolecule = new VueMolecule();
    AtomeDecorateur atomeDecorateur = new AtomeDecorateur(vueMolecule);
    ElectronDecorateur electronDecorateur = new ElectronDecorateur(atomeDecorateur);
    electronDecorateur.affiche();
  }
}
