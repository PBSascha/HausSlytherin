public interface ICreatureRepository
{
    //erstelle Methoden Add(), GetAll(), GetByName()
    void Add(Creature creature);
    List<Creature> GetAll();
    Creature GetByName(string name);
}