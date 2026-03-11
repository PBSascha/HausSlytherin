//Implementiere Interface in zwei Klassen
public class Spell : IRateable
{
    public int DangerLevel { get; set; }
    public bool Forbidden { get; set; }

    public int GetDangerLevel()
    {
        return DangerLevel;
    }

    public bool IsForbidden()
    {
        return Forbidden;
    }
}

public class Potion : IRateable
{
    public int DangerLevel { get; set; }
    public bool Forbidden { get; set; }

    public int GetDangerLevel()
    {
        return DangerLevel;
    }

    public bool IsForbidden()
    {
        return Forbidden;
    }
}