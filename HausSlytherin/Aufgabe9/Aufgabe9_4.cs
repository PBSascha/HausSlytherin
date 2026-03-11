//Verbinde Repository mit Service.
public class CreatureService
{
    private ICreatureRepository repository;

    public CreatureService(ICreatureRepository repository)
    {
        this.repository = repository;
    }

    public void AddCreature(Creature creature)
    {
        repository.Add(creature);
    }

    public Creature GetCreature(string name)
    {
        return repository.GetByName(name);
    }

    public List<Creature> GetAllCreatures()
    {
        return repository.GetAll();
    }
}
