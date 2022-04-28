using System.ComponentModel.DataAnnotations;

namespace OrderManager.Models
{
    public class OrderViewModel
    {
        [Key]
        public int OrderID { get; set; }
        public decimal? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipName { get; set; }
    }
}