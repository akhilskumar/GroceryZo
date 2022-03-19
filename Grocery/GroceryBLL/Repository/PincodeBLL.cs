using GroceryBLL;
using GroceryBOL;
using GroceryDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBLL
{
    public class PincodeBLL : IPincodeBLL
    {
        private IPincodeDAL _pincodeDAL;    

        public PincodeBLL(IPincodeDAL pincodeDAL )
        {
            _pincodeDAL = pincodeDAL;
        }
        public PincodeDTO Add(PincodeDTO pincodeDTO)
        {
            try
            {
                return _pincodeDAL.Add(pincodeDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
            return (_pincodeDAL.Delete(Id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PincodeDTO> GetAll()
        {

            try
            {
                return _pincodeDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PincodeDTO GetById(int Id)
        {

            try
            {
                return _pincodeDAL.GetById(Id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PincodeDTO Update(PincodeDTO pincodeDTO)
        {

            try
            {
              return   _pincodeDAL.Update(pincodeDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
