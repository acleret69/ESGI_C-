namespace ESGI_C_.Adapter;

public class listPerso
{
     static void Main(string[] args)
     {
          saiyan goku = new saiyan();
          Namekina piccolo = new Namekina();
          AndroidAdapter c17 = new AndroidAdapter();

          Console.WriteLine("goku attack: "+goku.attack());
          Console.WriteLine("piccolo attack: "+piccolo.attack());
          Console.WriteLine("c17 attack: "+c17.attack());
     }
     
}