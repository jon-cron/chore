namespace chore.Models
{
    public class Chore
    {
        public Chore(int id, string description, int compensation, string day)
        {
            Id = id;
            Description = description;
            Compensation = compensation;
            Day = day;
        }
        public int Id { get; set;}
        public string Description { get; set;}
        public int Compensation { get; set;}
        public string Day { get; set;}
    }

}