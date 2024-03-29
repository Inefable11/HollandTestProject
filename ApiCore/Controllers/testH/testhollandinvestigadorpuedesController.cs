﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBussinessLogic.Interfaces.testH;
using ApiModel.testH;
using ApiModel._ResponseDTO;

namespace ApiCore.Controllers.testH
{
    [Route("api/testhollandinvestigadorpuedes")]
    [ApiController]
    public class testhollandinvestigadorpuedesController : ControllerBase
    {
        private ITesthollandinvestigadorpuedesLogic _testhollandinvestigadorpuedes;
        public ResponseDTO _ResponseDTO;
        public testhollandinvestigadorpuedesController(ITesthollandinvestigadorpuedesLogic testhollandinvestigadorpuedes)
        {
            _testhollandinvestigadorpuedes = testhollandinvestigadorpuedes;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.GetList()));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.GetById(id)));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] testHollandInvestigadorPuedes obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.Insert(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] testHollandInvestigadorPuedes obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] testHollandInvestigadorPuedes obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _testhollandinvestigadorpuedes.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }
}
