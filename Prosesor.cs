public class Prosesor
{
    public string merk;
    public string type;

    public Prosesor(string merk, string type)
    {
        this.merk = merk;
        this.type = type;
    }
}

public class Intel : Prosesor
{
    public Intel(string type) : base("Intel", type){
    }
}

public class AMDps : Prosesor
{
    public AMDps(string type) : base("AMD", type){
    }
}

public class Corei3 : Intel
{
    public Corei3() : base("Core i3"){
    }
}

public class Corei5 : Intel
{
    public Corei5() : base("Core i5"){
    }
}

public class Corei7 : Intel
{
    public Corei7() : base("Core i7"){
    }
}

public class Ryzen : AMDps
{
    public Ryzen() : base("RAYZEN"){
    }
}

public class Athlon : AMDps
{
    public Athlon() : base("ATHLON"){
    }
}
