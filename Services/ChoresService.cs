namespace chore.Services;
  public class ChoresService
  {
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo){
        _repo = repo;
    }
    internal List<Chore> Get()
    {
      List<Chore> chores = _repo.Get();
      return chores;
    }
    internal Chore Create(Chore choreData)
    {
        Chore newChore = _repo.Create(choreData);
        return newChore;
    }
    internal string Remove(int id)
    {
        string message = _repo.Remove(id);
        return message;
    }

  internal Chore GetOne(int id)
  {
    Chore chore = _repo.GetOne(id);
    return chore;
  }
}
