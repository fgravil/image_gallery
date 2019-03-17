using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageData;
using ImageData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IImage imageService;

        public ImageController(IImage imageService)
        {
            this.imageService = imageService;
        }
        // GET: api/Image
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(imageService.GetAll());
        }

        // GET: api/Image/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var image = imageService.GetImageById(Guid.Parse(id));
            return Ok(image);
        }

        // POST: api/Image
        [HttpPost]
        public IActionResult Post([FromBody] Image image)
        {
            imageService.AddImage(image);
            return Ok();
        }

        // PUT: api/Image/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
