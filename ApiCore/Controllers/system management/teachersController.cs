using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApiBussinessLogic.Interfaces.system_management;
using ApiModel.system_management;
using ApiModel._ResponseDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ApiCore.Controllers.system_management
{
    [Route("api/teachers")]
    [ApiController]
    public class teachersController : ControllerBase
    {
        private ITeachersLogic _teachers;
        public ResponseDTO _ResponseDTO;
        private IConfiguration Configuration;
        private IAccesssystemLogic _accesssystem;
        public teachersController(ITeachersLogic teachers, IConfiguration configuration, IAccesssystemLogic accesssystem)
        {
            _teachers = teachers;
            Configuration = configuration;
            _accesssystem = accesssystem;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.GetList()));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.GetById(id)));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpGet]
        [Route("GetTeacherGrid")]
        public IActionResult GetTeacherGrid()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.GetTeacherGrid()));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpGet]
        [Route("validaEmail/{email}")]
        public IActionResult validaEmail(string email)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.validaEmail(email)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] teachers obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.Insert(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        [Route("insertTeacher")]
        public IActionResult insertTeacher(IFormCollection data, IFormFile file)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                teachers tt = new teachers();
                accessSystem aa = new accessSystem();
                var teachersJson = data["teacher"];
                var accessSystemJson = data["accessSystem"];
                string ruta = Configuration["rutaFotoUser"];
                tt = JsonConvert.DeserializeObject<teachers>(teachersJson);
                aa = JsonConvert.DeserializeObject<accessSystem>(accessSystemJson);
                var result = _teachers.Insert(tt);
                aa.idUser = result;
                if (file == null)
                {
                    tt.img = "estudiante-universitario.png";
                }
                else
                {
                    string nombreArchivo = Path.Combine(ruta, "user" + result + "p.jpg");
                    using (Stream fileStream = new FileStream(nombreArchivo, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    tt.img = "user" + result + "p.jpg";
                }
                _teachers.Update(tt);
                _accesssystem.Insert(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, result));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] teachers obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                accessSystem aa = new accessSystem();
                aa = _accesssystem.GetByUpdate(obj.id, 2);
                aa.userName = obj.email;
                _accesssystem.Update(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpPost]
        [Route("delete")]
        public IActionResult Delete([FromBody] teachers obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                _accesssystem.deleteAccesos(obj.email);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _teachers.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }
}
