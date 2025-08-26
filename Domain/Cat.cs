namespace Domain.Entities
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int BreedId { get; set; }
        public Breed Breed { get; set; }
    }
}
