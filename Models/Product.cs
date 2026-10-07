namespace FoodApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public bool Disponible { get; set; }
        public List<ProductOption> Opciones { get; set; } = new();
    }

    public class ProductOption
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int ProductId { get; set; }
    }
}