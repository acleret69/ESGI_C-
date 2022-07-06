namespace ESGI_C_.Adapter;

public class saiyan : Warrior
{
    public int attaque_base { get; set; }

    public int attack()
    {
        var rand = new Random();
        return rand.Next(14) * 100 + this.attaque_base;
    }
}