namespace ESGI_C_.Adapter;

public class android
{
    public int punch()
    {
        return 10;
    }

    public int kick()
    {
        var rand = new Random();
        return rand.Next(100) * this.punch() + this.punch();
    }
    
}