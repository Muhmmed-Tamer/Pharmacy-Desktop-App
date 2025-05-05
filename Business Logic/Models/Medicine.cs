using System.ComponentModel.DataAnnotations;

namespace Business_Logic.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        [MinLength(0)]
        public int Quantity { get; set; }
        public decimal Price_Per_Unit { get; set; }

        public virtual ICollection<Cart>? Carts { get; set; }
    }
}
