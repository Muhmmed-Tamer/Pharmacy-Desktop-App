using Business_Layer.Repositories;
using Business_Logic.Data;
using Business_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class CartRepository : ICartRepository
    {
        ContextData Data;
        public CartRepository(ContextData Data)
        {
            this.Data = Data;
        }
        public bool Add(Cart entity)
        {
            try
            {
                Data.Carts.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Cart entity)
        {
            try
            {
                Data.Remove(GetById(entity.Id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Cart> GetAll()
        {
            try
            {
                return Data.Carts.ToList();
            }
            catch
            {
                return null;
            }
        }

        public Cart GetById(int id)
        {
            try
            {
                return Data.Carts.FirstOrDefault(m => m.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public Cart GetCartByMedicineId(int MedicineId)
        {
            try
            {
                return Data.Carts.FirstOrDefault(m => m.MedicineId == MedicineId);
            }

            catch
            {
                return null;
            }
        }

        public List<Cart> GetMedicinesThatIsWantToSellItOrThatSelled(bool SelledOrNotSelled)
        {
            try
            {
                if(SelledOrNotSelled)
                {
                    return Data.Carts.Where(m => m.MedicineIsSelling == true).ToList();
                }
                else
                {
                    return Data.Carts.Where(m => m.MedicineIsSelling == false).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool Save()
        {
            try
            {
                Data.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Cart entity)
        {
            try
            {
                Data.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void UpdateMedicineIsSelled(int MedicineId)
        {
            try
            {
                Data.Update(GetCartByMedicineId(MedicineId));
            }
            catch
            {
                throw;
            }
        }
    }
}
