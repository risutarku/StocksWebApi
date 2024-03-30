using System.ComponentModel.DataAnnotations;

namespace asp.net_web_api_test.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be less than 5 characters")]
        [MaxLength(200, ErrorMessage = "Title can`t be more than 200 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be less than 5 characters")]
        [MaxLength(200, ErrorMessage = "Content can`t be more than 200 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
