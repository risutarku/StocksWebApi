using asp.net_web_api_test.Data;
using asp.net_web_api_test.Interfaces;
using asp.net_web_api_test.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Runtime.InteropServices;

namespace asp.net_web_api_test.Controllers
{
    [Route("api/commet")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comment = await _commentRepository.GetAllAsync();

            var commentDto = comment.Select(s => s.ToCommentDto());

            return Ok(commentDto);
        }
    }
}
