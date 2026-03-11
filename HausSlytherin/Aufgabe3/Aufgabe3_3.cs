namespace HausSlytherin.Aufgaben
{
    class Basilisk
    {
        private int dangerLevel {get; set;}

        // Getter und Setter Methoden
        public int GetDangerLevel() => dangerLevel;

        public void SetDangerLevel(int newLevel)
        {
            dangerLevel = newLevel;
        }
    }
}