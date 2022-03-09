using GroceryBOL.Entities;
using GroceryDAL.DbContexts;
using GroceryDAL.Interface;
using GroceryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDAL.Repository
{
    public class PincodeDAL:IPincodeDAL
    {
        private readonly GroceryZoContext _context ;

        public PincodeDAL(GroceryZoContext context)
        {
            _context = context;
        }
        #region Save
        public PincodeDTO Add(PincodeDTO pincodeDTO)
        {
            try
            {
            Pincode pincode = new Pincode();
            CopyFrom(pincodeDTO, pincode);
            _context.Pincodes.Add(pincode);
            Save();
            CopyTo(pincodeDTO, pincode);
            return pincodeDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        } 
        #endregion
        #region GetAll
        public List<PincodeDTO> GetAll()
        {
            try
            {
                List<Pincode> pincodes = _context.Pincodes.Where(x => x.Flag == true).ToList();
                List<PincodeDTO> pincodeDTOsList=new List<PincodeDTO>();
                foreach(var pincode in pincodes)
                {
                    PincodeDTO pincodeDTO = new PincodeDTO();
                    CopyTo(pincodeDTO, pincode);
                    pincodeDTOsList.Add(pincodeDTO);
                }
                return pincodeDTOsList;
            }

            catch (Exception exception)
            {
                throw;
            }
        }

        #endregion
        #region Get By Id
        public PincodeDTO GetById(int Id)
        {
            try
            {
            Pincode pincode = _context.Pincodes.Where(x => x.Id == Id && x.Flag == true).FirstOrDefault();
            if (pincode == null) return new PincodeDTO();
                PincodeDTO pincodeDTO = new PincodeDTO();
                CopyTo(pincodeDTO, pincode);
                return pincodeDTO;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion
        #region Update
        public PincodeDTO Update(PincodeDTO pincodeDTO)
        {
            try
            {
                Pincode pincode = new Pincode();
                CopyFrom(pincodeDTO, pincode);
                _context.Pincodes.Update(pincode);
                CopyTo(pincodeDTO, pincode);
                return pincodeDTO;

            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion
        #region Delete
        public bool Delete(int Id)
        {
            bool IsSuccess=false;
            try
            {
                Pincode pincode = _context.Pincodes.FirstOrDefault(x => x.Id == Id);
                _context.Pincodes.Remove(pincode);
                IsSuccess=true;
            }
            catch(Exception ex)
            {
                throw;
                IsSuccess=false;
            }
            return IsSuccess;
        }
        #endregion

        #region Generic Function
        public void Save()
        {
            try
            {
                _context.SaveChanges();

            }
            catch (Exception exception)
            {
                throw;
            }
        }

        #endregion

        #region CopyFunctions
        PincodeDTO CopyTo(PincodeDTO destination,Pincode source)
        {
            if (source != null)
            {
            destination.Id = source.Id;
            destination.Flag = source.Flag;
            destination.Pincode1 = source.Pincode1;
            destination.Location = source.Location;
            destination.DeliveryCharge= source.DeliveryCharge;
            }
            return destination;

        }
        Pincode CopyFrom(PincodeDTO source,Pincode destination)
        {
            destination.Id = source.Id;
            destination.Flag = source.Flag;
            destination.Pincode1 = source.Pincode1;
            destination.Location = source.Location;
            destination.DeliveryCharge= source.DeliveryCharge;
            return destination;
        }
        #endregion
    }
}
