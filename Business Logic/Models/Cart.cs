using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public string MedicineName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateAdded { get; set; }

        public bool MedicineIsSelling { get; set; } = false;    
        // Navigation property
        public virtual Medicine? Medicine { get; set; }
        public virtual ApplicationUser? User { get; set; }
    }
}
