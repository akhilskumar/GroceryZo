﻿using GroceryBLL.Interface;
using GroceryBOL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Grocery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PincodeController : BaseApiController
    {
        private readonly IPincodeBLL _pincodeBLL;
        public PincodeController(IPincodeBLL pincodeBLL)
        {
            _pincodeBLL = pincodeBLL;

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<PincodeDTO> pincodeDtoList = new();
            try
            {
                pincodeDtoList= _pincodeBLL.GetAll();
            }
            catch(Exception exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new APIResponce { Status = "Error", Message = exception.Message, Pincodes = pincodeDtoList, StatusCode = StatusCodes.Status400BadRequest });
            }
            return Ok(new APIResponce { Status = "Success", Message = "Data Fetched Successfully", Pincodes = pincodeDtoList, StatusCode = StatusCodes.Status200OK });
        }

        [HttpGet]
        public IActionResult GetByID(int Id)
        {
           PincodeDTO pincodeDTO = new();
            try
            {
                pincodeDTO= _pincodeBLL.GetById(Id);
            }
            catch(Exception exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new APIResponce { Status = "Error", Message = exception.Message, pincodeDTO = pincodeDTO, StatusCode = StatusCodes.Status400BadRequest });
            }
            return Ok(new APIResponce { Status = "Success", Message = "Data Fetched Successfully", pincodeDTO = pincodeDTO, StatusCode = StatusCodes.Status200OK });
        }

        [HttpPost]
        public IActionResult UpdateById(PincodeDTO pincode)
        {
            PincodeDTO pincodeDTO = new PincodeDTO();
            try
            {
                pincodeDTO = _pincodeBLL.Update(pincode);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new APIResponce { Status = "Error", Message = exception.Message, pincodeDTO = pincodeDTO, StatusCode = StatusCodes.Status400BadRequest });
            }
            return Ok(new APIResponce { Status = "Success", Message = "Data Fetched Successfully", pincodeDTO = pincodeDTO, StatusCode = StatusCodes.Status200OK });
        }
        [HttpDelete]
        public IActionResult DeleteById(int Id)
        {
            bool IsSuccess = false;
            try
            {
                IsSuccess = _pincodeBLL.Delete(Id);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new APIResponce { Status = "Error", Message = exception.Message, IsSuccess = IsSuccess, StatusCode = StatusCodes.Status400BadRequest });
            }
            return Ok(new APIResponce { Status = "Success", Message = "Data Fetched Successfully", IsSuccess = IsSuccess, StatusCode = StatusCodes.Status200OK });
        }
        [HttpPost]
        public IActionResult SavePincode(PincodeDTO pincodeDTO)
        {
            PincodeDTO pincode = new();
            try
            {
                pincode = _pincodeBLL.Add(pincodeDTO);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new APIResponce { Status = "Error", Message = exception.Message, pincodeDTO = pincode, StatusCode = StatusCodes.Status400BadRequest });
            }
            return Ok(new APIResponce { Status = "Success", Message = "Data Fetched Successfully", pincodeDTO = pincode, StatusCode = StatusCodes.Status200OK });
        }

    }
}
