namespace ESGI_C_.Adapter;

public class AndroidAdapter : Warrior
{


    private android android;

    public AndroidAdapter()
    {
         android = new android();
    }
    public int attaque_base { get; set; }

    public int attack()
    {
        var rand = new Random();
        return this.android.kick() + this.android.punch() + this.attaque_base;
    }
}