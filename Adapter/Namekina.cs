namespace ESGI_C_.Adapter;

public class Namekina : Warrior
{
    public int attaque_base { get; set; }
    
    public int attack()
    {
        var rand = new Random();
        return rand.Next(10) * 100 + this.attaque_base;
    }
    
    
}