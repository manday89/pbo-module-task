public class VGA
{
    public string merk;

    public VGA(string merk)
    {
        this.merk = merk;
    }
}

public class AMDv : VGA
{
    public AMDv() : base("AMD"){
    }
}

public class Nvidia : VGA
{
    public Nvidia() : base("Nvidia"){
    }
}