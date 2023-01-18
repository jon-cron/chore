namespace chore.Repositories;

    public class ChoresRepository
    {
        private List<Chore> choreDb;

        public ChoresRepository()
        {
            this.choreDb = new List<Chore>(){
                new Chore(1, "rake all of the leaves", 2, "Wednesday"),
                new Chore(2, "do laundry", 53, "Thursday"),
                new Chore(3, "scrub the floor with your toothbrush", 1, "Everyday"),
                new Chore(4, "Dishes", 3, "Saturday"),
                new Chore(5, "work in the sweat shop", 0, "Every Weekend"),
            };
        }

  internal List<Chore> Get()
  {
    return choreDb;
  }
  internal Chore Create(Chore choreData)
  {
    choreData.Id = choreDb[choreDb.Count - 1].Id + 1;
    choreDb.Add(choreData);
    return choreData;
  }
  internal string Remove(int id)
  {
    Chore choreToRemove = choreDb.Find(c => c.Id == id);
    bool result = choreDb.Remove(choreToRemove);
    if(result)
    {
      return $"{choreToRemove.Description} was removed";
    }
    return "no chore to remove.";
  }

  internal Chore GetOne(int id)
  {
    Chore chore = choreDb.Find(c => c.Id == id);
    return chore;
  }
}
