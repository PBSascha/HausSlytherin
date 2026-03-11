
namespace HausSlytherin.Aufgaben{
    class Basilisk
    {
        private int dangerLevel {get; set;}

        public int GetDangerLevel() => dangerLevel;

        public void SetDangerLevel(int newLevel)
        {
            // Validierung des neuen Werts
            if (newLevel < 1 || newLevel > 10)
            {
                Console.WriteLine("Danger level must be between 1 and 10.");
                return;
            }
            dangerLevel = newLevel;
        }
    }
}