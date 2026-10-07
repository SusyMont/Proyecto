namespace FoodApi.Models
{
    public class Addition
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Available { get; set; } = true;
    }
}