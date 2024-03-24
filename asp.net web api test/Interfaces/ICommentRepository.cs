using asp.net_web_api_test.Models;

namespace asp.net_web_api_test.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment?>> GetAllAsync();
    }
}
