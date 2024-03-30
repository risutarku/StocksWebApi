using asp.net_web_api_test.Dtos.Comment;
using asp.net_web_api_test.Dtos.Stock;
using asp.net_web_api_test.Helpers;
using asp.net_web_api_test.Models;

namespace asp.net_web_api_test.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment?>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        Task<Comment?> DeleteAsync(int id);

    }
}
