namespace HausSlytherin.Aufgaben
{
    public class Creature
    {
        public string Name { get; set; } = string.Empty;
        public int DangerLevel { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("The creature makes a sound!");
        }
    }

    public class Dragon : Creature  
    {
        public int GetDangerLevel() => DangerLevel;
        
        public override void MakeSound() => Console.WriteLine("The dragon roars!");
    }
    public class Spider : Creature
    {
        public int GetDangerLevel() => DangerLevel;
        public override void MakeSound() => Console.WriteLine("The spider hisses!");

    }
    public class Phoenix : Creature
    {
       public int GetDangerLevel() => DangerLevel;
       public override void MakeSound() => Console.WriteLine("The phoenix screeches!");

    }
}