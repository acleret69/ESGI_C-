using System;
using ESGI_C_.Decorator;

public class DetailsMolecule
{
  static void Main(string[] args)
  {
    VueMolecule vueMolecule = new VueMolecule();
    AtomeDecorateur atomeDecorateur = new AtomeDecorateur(vueMolecule);
    ElectronDecorateur electronDecorateur = new ElectronDecorateur(atomeDecorateur);
    ChargeElementaireDecorateur chargeElementaire = new ChargeElementaireDecorateur(electronDecorateur);
    chargeElementaire.affiche();
  }
}
