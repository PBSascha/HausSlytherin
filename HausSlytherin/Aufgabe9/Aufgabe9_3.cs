//implementiere Repository
public class CreatureRepository : ICreatureRepository
{
    private List<Creature> creatures = new List<Creature>();

    public void Add(Creature creature)
    {
        creatures.Add(creature);
    }

    public List<Creature> GetAll()
    {
        return creatures;
    }

    public Creature GetByName(string name)
    {
        return creatures.FirstOrDefault(c => c.Name == name);
    }
}
