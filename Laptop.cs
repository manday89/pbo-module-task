public class Laptop
{
    public string merk;
    public string type;
    public VGA vga;
    public Prosesor pcc;

    public Laptop(string merk, string type, VGA vga, Prosesor pcc)
    {
        this.merk = merk;
        this.type = type;
        this.vga = vga;
        this.pcc = pcc;
    }

    public void LaptopDinyalakan()
{
    Console.WriteLine($"Laptop {merk} {type} telah dinyalakan.");
}

public void LaptopDimatikan()
{
    Console.WriteLine($"Laptop {merk} {type} telah dimatikan.");
}
}

public class ASUS : Laptop
{
    public ASUS(string type, VGA vga, Prosesor pcc) : base("ASUS", type, vga, pcc){
    }
}

public class ACER : Laptop
{
    public ACER(string type, VGA vga, Prosesor pcc) : base("ACER", type, vga, pcc){
    }
}

public class Lenovo : Laptop
{
    public Lenovo(string type, VGA vga, Prosesor pcc) : base("Lenovo", type, vga, pcc){
    }
}

public class ROG : ASUS
{
    public ROG(VGA vga, Prosesor pcc) : base("ROG", vga, pcc){
    }
}

public class Vivobook : ASUS
{
    public Vivobook(VGA vga, Prosesor pcc) : base("Vivobook", vga, pcc){
    }

    public void Ngoding(){
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

public class Swift : ACER
{
    public Swift(VGA vga, Prosesor pcc) : base("Swift", vga, pcc){
    }
}

public class Predator : ACER
{
    public Predator(VGA vga, Prosesor pcc) : base("Predator", vga, pcc){
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {type} sedang memainkan game");
    }
}

public class IdeaPad : Lenovo
{
    public IdeaPad(VGA vga, Prosesor pcc) : base("IdeaPad", vga, pcc){
    }
}

public class Legion : Lenovo
{
    public Legion(VGA vga, Prosesor pcc) : base("Legion", vga, pcc){
    }
}