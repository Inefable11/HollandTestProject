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
    [Route("api/students")]
    [ApiController]
    public class studentsController : ControllerBase
    {
        private IStudentsLogic _students;
        public ResponseDTO _ResponseDTO;
        private IConfiguration Configuration;
        private IAccesssystemLogic _accesssystem;
        public studentsController(IStudentsLogic students, IConfiguration configuration, IAccesssystemLogic accesssystem)
        {
            _students = students;
            Configuration = configuration;
            _accesssystem = accesssystem;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.GetList()));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.GetById(id)));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] students obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.Insert(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        [Route("insertStudent")]
        public IActionResult insertStudent(IFormCollection data, IFormFile file)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                students ss = new students();
                accessSystem aa = new accessSystem();
                var studentJson = data["student"];
                var accessSystemJson = data["accessSystem"];
                string ruta = Configuration["rutaFotoUser"];
                ss = JsonConvert.DeserializeObject<students>(studentJson);
                aa = JsonConvert.DeserializeObject<accessSystem>(accessSystemJson);
                var result = _students.Insert(ss);
                aa.idUser = result;
                if (file == null)
                {
                    ss.img = "estudiante-universitario.png";
                }
                else
                {
                    string nombreArchivo = Path.Combine(ruta, "user" + result + "e.jpg");
                    using (Stream fileStream = new FileStream(nombreArchivo, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    ss.img = "user" + result + "e.jpg";
                }
                
                _students.Update(ss);
                _accesssystem.Insert(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, result));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] students obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                accessSystem aa = new accessSystem();
                aa = _accesssystem.GetByUpdate(obj.id, 3);
                aa.userName = obj.email;
                _accesssystem.Update(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpPost]
        [Route("delete")]
        public IActionResult Delete([FromBody] students obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                _accesssystem.deleteAccesos(obj.email);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _students.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }

}
