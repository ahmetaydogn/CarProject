namespace Entities.DTOs;

public class SaleDto : IDto
{
    public int SaleId { get; set; }
    public int CustomerId { get; set; }
    public int? ProductId { get; set; }
    public int? SubProductId { get; set; }
    public string CustomerFullName { get; set; }
    public string CustomerPhone { get; set; }
    public string ProductName { get; set; }
    public DateTime SaleDate { get; set; }
    public short Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Profit { get; set; }
    public string PaymentMethod { get; set; }
    public string? BillNumber { get; set; }
}
