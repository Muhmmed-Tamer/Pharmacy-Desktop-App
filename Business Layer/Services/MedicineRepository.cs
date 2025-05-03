using Business_Layer.Repositories;
using Business_Logic.Data;
using Business_Logic.Models;
using Pharmacy_Desktop_App.Pharmacist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class MedicineRepository : IMedicineRepository
    {
        ContextData Data;
        public MedicineRepository(ContextData Data)
        {
            this.Data = Data;
        }
        public bool Add(Medicine entity)
        {
            try
            {
                Data.Medicines.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Medicine entity)
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

        public IEnumerable<Medicine> GetAll()
        {
            try
            {
                return Data.Medicines.ToList();
            }
            catch
            {
                return null;
            }
        }

        public Medicine GetById(int id)
        {
            try
            {
                return Data.Medicines.FirstOrDefault(m => m.Id == id);
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

        public List<Medicine> SearchAboutMedicineByKeyUp(string SearchText)
        {
            try
            {
                List<Medicine> medicines = new List<Medicine>();
                foreach (var item in GetAll())
                {
                    if (item.Name.ToLower().Contains(SearchText.ToLower()))
                    {
                        medicines.Add(item);
                    }
                }
                return medicines;
            }
            catch
            {
                return null;
            }
        }

        public Medicine SearchByMedicineNumber(int medicineNumber)
        {
            try
            {
                if (GetAll() != null)
                {
                    return GetAll().FirstOrDefault(m => m.Number == medicineNumber);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Medicine> SearchByValid(Check check)
        {
            try
            {
                List<Medicine> AllMedicines = GetAll().ToList();
                
                    if (check == Check.Valid)
                    {
                        return AllMedicines.Where(M => M.ExpiryDate > DateTime.Now).ToList();
                    }
                    else if (check == Check.InValid)
                    {
                        return AllMedicines.Where(M => M.ExpiryDate < DateTime.Now).ToList();
                    }
                    else
                    {
                        return AllMedicines;
                    }

            }
            catch
            {
                return null;
            }
        }

        public bool Update(Medicine entity)
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
    }
}
