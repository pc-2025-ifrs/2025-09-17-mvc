using _2025_09_17_mvc.Model;
using Microsoft.AspNetCore.Mvc;

namespace _2025_09_17_mvc.Controllers;

// : => extends => estende
[ApiController] // é uma API (devolve apenas dados)
[Route("api/[controller]")] //
public class VideoController : ControllerBase
{
    // TODO: trazer os vídeos do banco de dados
    private static List<Video> _videos = [
        new Video {
            Id = "qhg52ja",
            Title = "Gagnam Style",
            Likes = 7_233_488
        },
        new Video {
            Id = "88jkw72",
            Title = "Conhecendo o IFRS",
            Likes = 2_343
        }
    ];

    [HttpGet("list")]
    public ActionResult<List<Video>> GetVideos()
    {
        // Response.StatusCode = StatusCodes.Status200OK;
        return Ok(_videos);
    }

}