using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ApiBussinessLogic.Interfaces.system_management;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.system_management;
using ApiModel.testH;
using ApiModel._RequestDTO;
using ApiModel._ResponseDTO;

namespace ApiCore.Controllers.testH
{
    [Route("api/testhollanddetails")]
    [ApiController]
    public class testhollanddetailsController : ControllerBase
    {
        private ITesthollanddetailsLogic _testhollanddetails;
        private IParameterdetailsLogic _parameterdetails;
        public ResponseDTO _ResponseDTO;
        public testhollanddetailsController(ITesthollanddetailsLogic testhollanddetails, IParameterdetailsLogic parameterdetails)
        {
            _testhollanddetails = testhollanddetails;
            _parameterdetails = parameterdetails;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.GetList()));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        [Route("GetTestDetail")]
        public IActionResult GetTestDetail([FromBody] testDetailRequestDTO obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                    return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.GetTestDetail(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpGet]
        [Route("GetTestChart/{id:int}")]
        public IActionResult GetTestChart(int id)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.GetTestChart(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.GetById(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpGet]
        [Route("GetByIdString/{id}")]
        public IActionResult GetByIdString(string id)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] testHollandDetails obj)
        {
            _ResponseDTO = new ResponseDTO();
            
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.Insert(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        private void verPropiedad(PropertyInfo oProperty)
        {
            var xx = oProperty;
        }

        [HttpPut]
        public IActionResult Update([FromBody] testHollandDetails obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] testHollandDetails obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollanddetails.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }

    public class scoreSort
    {
        public string name { get; set; }
        public int value { get; set; }
    }
}
