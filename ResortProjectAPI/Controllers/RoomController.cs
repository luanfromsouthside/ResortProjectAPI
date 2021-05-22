using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ResortProjectAPI.IServices;
using ResortProjectAPI.ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService service;
        private readonly IImageService imgSV;

        public RoomController(IRoomService service, IImageService imgSV)
        {
            this.service = service;
            this.imgSV = imgSV;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await service.GetAll();
            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Details(string id) 
        {
            var room = await service.GetByID(id);
            if (room == null) return NotFound();
            return Ok(room);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(Room model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values);
            if (await service.GetByID(model.ID) != null) return BadRequest("Room was existed");
            try
            {
                await service.Create(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Server can not create");
            }
        }

        [HttpPost("edit_info")]
        public async Task<IActionResult> EditInfo(Room model)
        {
            if (await service.GetByID(model.ID) == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState.Values);
            try
            {
                await service.Update(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Server can not create");
            }
        }

        [HttpPost("add_img/{id}")]
        public async Task<IActionResult> AddImg(string id, string[] listImg)
        {
            //IEnumerable<string> listImg = data["listImg"].ToObject<IEnumerable<string>>();
            var room = await service.GetByID(id);
            if (room == null) return NotFound();
            try
            {
                foreach(var item in listImg)
                {
                    await imgSV.Create(new Image()
                    {
                        RoomID = id,
                        URL = item
                    });
                }
                return Ok();
            }
            catch
            {
                return BadRequest("Server can not add image");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(string id)
        {
            if (await service.GetByID(id) == null) return NotFound();
            try
            {
                await service.Delete(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Server can not remove room");
            }
        }

        [HttpDelete("img/{id}")]
        public async Task<IActionResult> RemoveImg(string url)
        {
            if (await imgSV.GetByURL(url) == null) return NotFound();
            try
            {
                await imgSV.Remove(url);
                return Ok();
            }
            catch
            {
                return BadRequest("Server can not remove image");
            }
        }
    }
}
