using Business_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Repositories
{
    public interface ICartRepository:IRepository<Cart>
    {
        void UpdateMedicineIsSelled(int MedicineId);
        Cart GetCartByMedicineId(int MedicineId);
        List<Cart> GetMedicinesThatIsWantToSellItOrThatSelled(bool SelledOrNotSelled);
    }
}
