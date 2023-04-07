using System;

public class Program{
    static void Main(string[] args){
        Laptop laptop1, laptop2;
        Predator predator;

        VGA vgaLaptop1 = new Nvidia();
        Prosesor pccLaptop1 = new Corei5();
        laptop1 = new Vivobook(vgaLaptop1, pccLaptop1);

        // laptop1.Ngoding();
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.pcc.merk);
        Console.WriteLine(laptop1.pcc.type);

        VGA vgaLaptop2 = new AMDv();
        Prosesor pccLaptop2 = new Ryzen();
        laptop2 = new IdeaPad(vgaLaptop2, pccLaptop2);

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        VGA vgaLaptop3 = new AMDv();
        Prosesor pccLaptop3 = new Corei7();
        predator = new Predator(vgaLaptop3, pccLaptop3);

        predator.BermainGame();

        ACER acer = new Predator(vgaLaptop2, pccLaptop2);

        // acer.BermainGame();

    }
}
