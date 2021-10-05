using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using videoGameApi.Models;
using videoGameApi.Services;

namespace videoGameApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoGameController : ControllerBase
    {
        public VideoGameController()
        {
        }

        // GET all action
        [HttpGet("getAll")]
        public ActionResult<List<VideoGame>> GetAll() =>
    VideoGameService.GetAll();

        // GET by Id action
        [HttpGet("findGame/{id}")]
        public ActionResult<VideoGame> Get(int id)
        {
            var game = VideoGameService.Get(id);

            if (game == null)
                return NotFound();

            return game;
        }

        // POST action
        [HttpPost("addGame")]
        public IActionResult Create(VideoGame game)
        {
            VideoGameService.Add(game);
            return CreatedAtAction(nameof(Create), new { id = game.id }, game);
        }

        // PUT action
        [HttpPut("updateGame/{id}")]
        public IActionResult Update(int id, VideoGame game)
        {
            if (id != game.id)
                return BadRequest();

            var existingGame = VideoGameService.Get(id);
            if (existingGame is null)
                return NotFound();

            VideoGameService.Update(game);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("deleteGame/{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = VideoGameService.Get(id);

            if (pizza is null)
                return NotFound();

            VideoGameService.Delete(id);

            return NoContent();
        }
    }
}