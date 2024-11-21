using ToysCore.Models;

namespace ToysSite;

public class SignBillReceiver
{
    public bool IsDelivery {get;set;}
    public string CPhone {get;set;}
    public string CAddress {get;set;}
    public ICollection<SignBillProduct> PaidProducts {get;set;}
}