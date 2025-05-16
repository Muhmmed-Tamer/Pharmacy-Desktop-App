using Business_Logic.Models;
using Pharmacy_Desktop_App.Pharmacist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Repositories
{
    public interface IMedicineRepository : IRepository<Medicine>
    {
        List<Medicine> SearchAboutMedicineByKeyUp(string SearchText);
        List<Medicine> SearchByValid(Check check);
        Medicine SearchByMedicineNumber(int medicineNumber);

    }
    
}
