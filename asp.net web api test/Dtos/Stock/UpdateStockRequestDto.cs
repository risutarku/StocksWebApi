using System.ComponentModel.DataAnnotations;

namespace asp.net_web_api_test.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(6, ErrorMessage = "Symbol can`t be more than 6 characters")]
        public string Symbol { get; set; } = string.Empty; 
        [Required]
        [MaxLength(15, ErrorMessage = "Company Name can`t be more than 15 characters")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(0.1, 100000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 10000)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Industry can`t be more than 15 characters")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 10_000_000_000_000)]
        public long MarketCap { get; set; }
    }
}
