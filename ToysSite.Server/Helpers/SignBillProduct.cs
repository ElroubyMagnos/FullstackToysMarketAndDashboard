using ToysCore.Models;

namespace ToysSite;

public class SignBillProduct
{
    public int ID { get; set; }
    public byte[] Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double BuyPrice { get; set; }
    public double Price { get; set; }
    public double DiscountNow { get; set; }
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}