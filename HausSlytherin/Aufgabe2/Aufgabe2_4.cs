namespace HausSlytherin.Aufgaben
{    
    class Drag0n
    {
        public string _name { get; set; }
        public int _danger { get; set; }

        public Drag0n(string name, int danger)
        {
            _name = name;
            _danger = danger;
        }

        //2.4 Methode hinzufügen:
        public void PrintInfo()
        {
            Console.WriteLine($"Dragon Name: {_name}, Danger Level: {_danger}");
        }
    }
}