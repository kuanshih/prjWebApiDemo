namespace prjWebApi.Models.DTO
{
    public class ProductMinClass
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }
}
