namespace HausSlytherin.Aufgaben
{
    public class Creature
    {
        public string Name { get; set; } = string.Empty;
        public int DangerLevel { get; set; }
    }

    //Erstelle Unterklassen
    public class Dragon : Creature  
    {
        public int GetDangerLevel() => DangerLevel;
    }
    public class Spider : Creature
    {
        public int GetDangerLevel() => DangerLevel;
    }
    public class Phoenix : Creature
    {
        public int GetDangerLevel() => DangerLevel;
    }
}
