public class CreateCreature
{
    //Erstelle Methoden AddCreature, GetCreature und RemoveCreature
    public void AddCreature(Creature creature)
    {
        creatures.Add(creature);
    }
    public void GetCreature(string name)
    {
        creatures.find(creature => creature.Name == name);
    }
    public void RemoveCreature()
    {
        creaturs.Remove(creature);
    }   
}
/*
Das Model soll nur die Daten und Eigenschaften eines Objekts enthalten
(z. B. Name, Gefahrlevel).Die Logik zum Verwalten mehrerer Objekte wie Hinzufügen,
Suchen oder Löschen gehört nicht in das Model, weil sonst das Model zu viele Aufgaben hätte.
*/