using asp.net_web_api_test.Dtos.Stock;
using asp.net_web_api_test.Helpers;
using asp.net_web_api_test.Models;
using System.Text.Json.Serialization.Metadata;

namespace asp.net_web_api_test.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);

    }
}
