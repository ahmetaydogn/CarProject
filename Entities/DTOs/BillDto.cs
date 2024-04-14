namespace Entities.DTOs;

public class BillDto : IDto
{
    public string BillId { get; set; }
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public string SaleCustomerFullName { get; set; }
    public string SaleCustomerPhone { get; set; }
    public string SaleProductName { get; set; }
    public short Quantity { get; set; }
    public decimal MarketPrice { get; set; }
    public decimal SellPrice { get; set; }
    public decimal VATPrice { get; set; }
    public decimal SumPrice { get; set; }
    public string PaymentMethod { get; set; }
    public DateTime SaleDate { get; set; }
}
