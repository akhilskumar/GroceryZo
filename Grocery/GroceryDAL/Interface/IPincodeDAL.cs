using GroceryBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDAL
{
    public interface IPincodeDAL
    {
        PincodeDTO Add(PincodeDTO pincodeDTO);
        bool Delete(int Id);
        PincodeDTO Update(PincodeDTO pincodeDTO);
        PincodeDTO GetById(int Id);
        List<PincodeDTO> GetAll();
    }
}
