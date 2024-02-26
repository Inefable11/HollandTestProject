using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiModel._ResponseDTO;

namespace ApiCore.Controllers.system_management
{
    [Route("api/accesssystem")]
    [ApiController]
    public class accesssystemController : ControllerBase
    {
        private IAccesssystemLogic _accesssystem;
        public ResponseDTO _ResponseDTO;
        public accesssystemController(IAccesssystemLogic accesssystem)
        {
            _accesssystem = accesssystem;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.GetList()));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.GetById(id)));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpGet]
        [Route("deleteAccesos/{username}")]
        public IActionResult deleteAccesos(string username)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.deleteAccesos(username)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] accessSystem obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.Insert(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] accessSystem obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] accessSystem obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _accesssystem.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost("login")]
        public IActionResult LoguearUsuario([FromBody] CredencialesUsuaroBE usuario)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                if (usuario.typeLogin == 1)
                {
                    var obj = _accesssystem.LoguearUsuarioStaff(usuario);
                    return Ok(_ResponseDTO.Success(_ResponseDTO, obj));
                }
                if (usuario.typeLogin == 2)
                {
                    var obj = _accesssystem.LoguearUsuarioTeacher(usuario);
                    return Ok(_ResponseDTO.Success(_ResponseDTO, obj));
                }
                if (usuario.typeLogin == 3)
                {
                    var obj = _accesssystem.LoguearUsuarioStudent(usuario);
                    return Ok(_ResponseDTO.Success(_ResponseDTO, obj));
                }

                return Ok(_ResponseDTO.Success(_ResponseDTO, null));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }

}
