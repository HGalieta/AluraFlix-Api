using AluraFlixAPI.Data;
using AluraFlixAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AluraFlixAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public VideoController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetVideos()
        {
            List<Video> videos = _context.Videos.ToList();

            if (videos != null)
            {
                return Ok(videos);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetVideoById(int id)
        {
            Video video = _context.Videos.FirstOrDefault(v => v.Id == id);
            
            if (video != null)
            {
                return Ok(video);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult PostVideo(Video video)
        {
            _context.Add(video);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetVideoById), new { Id = video.Id }, video);
        }

        [HttpPut("{id}")]
        public IActionResult PutVideo(int id, [FromBody] VideoUpdate novoVideo)
        {
            Video video = _context.Videos.FirstOrDefault(v => v.Id == id);

            if (GetVideos != null)
            {
                _mapper.Map(novoVideo, video);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVideo(int id)
        {
            Video video = _context.Videos.FirstOrDefault(v => v.Id == id);

            if (video != null)
            {
                _context.Remove(video);
                _context.SaveChanges();
                return Ok(video);
            }

            return NotFound();
        }
    }
}
