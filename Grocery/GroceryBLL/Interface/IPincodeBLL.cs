﻿using GroceryBOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBLL.Interface
{
    public interface IPincodeBLL
    {
        PincodeDTO Add(PincodeDTO pincodeDTO);
        bool Delete(int Id);
        PincodeDTO Update(PincodeDTO pincodeDTO);
        PincodeDTO GetById(int Id);
        List<PincodeDTO> GetAll();
    }
}
