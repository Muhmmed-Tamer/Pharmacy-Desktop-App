using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Sales
    {
        public int Id { get; set; }
        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Medicine Medicine { get; set; }
    }
}
