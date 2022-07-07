public abstract class Decorateur :
  IMolecule
{
  protected IMolecule composant;

  public Decorateur(IMolecule composant)
  {
    this.composant = composant;
  }

  public virtual void affiche()
  {
    composant.affiche();
  }
}
