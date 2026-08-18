using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.Generic;

namespace Stackoverflow.Controllers
{
    [Route("api/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return new[] {
                new Post(1, "First post", "This is the first post."),
                new Post(2, "Second post", "This is the second post.")
            };
        }

    }

    public record Post(int Id, string Title, string Content);
}
