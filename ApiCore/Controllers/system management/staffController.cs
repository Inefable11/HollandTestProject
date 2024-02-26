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
    [Route("api/staff")]
    [ApiController]
    public class staffController : ControllerBase
    {
        private IStaffLogic _staff;
        public ResponseDTO _ResponseDTO;
        private IConfiguration Configuration;
        private IAccesssystemLogic _accesssystem;
        public staffController(IStaffLogic staff, IConfiguration configuration, IAccesssystemLogic accesssystem)
        {
            _staff = staff;
            Configuration = configuration;
            _accesssystem = accesssystem;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                return Ok(_ResponseDTO.Success(_ResponseDTO, _staff.GetList()));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _staff.GetById(id)));
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
                return Ok(_ResponseDTO.Success(_ResponseDTO, _staff.GetByIdString(id)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPost]
        [Route("insertStaff")]
        public IActionResult Insert(IFormCollection data, IFormFile file)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                staff ss = new staff();
                accessSystem aa = new accessSystem();
                var staffJson = data["staff"];
                var accessSystemJson = data["accessSystem"];
                string ruta = Configuration["rutaFotoUser"];
                ss = JsonConvert.DeserializeObject<staff>(staffJson);
                aa = JsonConvert.DeserializeObject<accessSystem>(accessSystemJson);
                var result = _staff.Insert(ss);
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
                _staff.Update(ss);
                _accesssystem.Insert(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, result));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] staff obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                accessSystem aa = new accessSystem();
                aa = _accesssystem.GetByUpdate(obj.id, 1);
                aa.userName = obj.email;
                _accesssystem.Update(aa);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _staff.Update(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
        [HttpPost]
        [Route("delete")]
        public IActionResult Delete([FromBody] staff obj)
        {
            _ResponseDTO = new ResponseDTO();
            try
            {
                _accesssystem.deleteAccesos(obj.email);
                return Ok(_ResponseDTO.Success(_ResponseDTO, _staff.Delete(obj)));
            }
            catch (Exception e)
            {
                return BadRequest(_ResponseDTO.Failed(_ResponseDTO, e.Message));
            }
        }
    }
}
