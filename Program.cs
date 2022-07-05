using System;

public class Program
{


    static void Main(string[] args)
    {
        Vendeur vendeur1 = Vendeur.Instance();
        vendeur1.nbVente = 10;
        Console.WriteLine(vendeur1.nbVente);
        Vendeur vendeur2 = Vendeur.Instance();
        vendeur2.nbVente = 20;
        Console.WriteLine(vendeur1.nbVente);
        Console.WriteLine(vendeur2.nbVente);
    }
}

public class Vendeur
    {
        private static Vendeur _instance = null;

        public int nbVente { get; set; }

        private Vendeur()
        {
        }

        public static Vendeur Instance()
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }
    }
