List<IRateable> items = new List<IRateable>();

items.Add(new Spell { Name = "Avada Kedavra", DangerLevel = 10, Forbidden = true });
items.Add(new Potion { Name = "Healing Potion", DangerLevel = 2, Forbidden = false });

foreach (IRateable item in items)
{
    Console.WriteLine("Danger Level: " + item.GetDangerLevel());
    Console.WriteLine("Forbidden: " + item.IsForbidden());
}