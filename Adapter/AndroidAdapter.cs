namespace ESGI_C_.Adapter;

public class AndroidAdapter : Warrior
{

    
    android android = new android();

    public AndroidAdapter(android android)
    {
        this.android = android;
    }
    public int attaque_base { get; set; }

    public int attack()
    {
        var rand = new Random();
        return this.android.kick() + this.android.punch() + this.attaque_base;
    }
}