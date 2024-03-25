using asp.net_web_api_test.Data;
using asp.net_web_api_test.Interfaces;
using asp.net_web_api_test.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace asp.net_web_api_test.Repostirory
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comment.ToListAsync();
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await _context.Comment.FindAsync(id);
        }
    }
}
