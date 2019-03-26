using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKeySenderApp
{
    class LoginResponse
    {
        public string user_code { get; set; }
        public string device_code { get; set; }
        public string expires_in { get; set; }
        public string interval { get; set; }
        public string verification_uri { get; set; }
        public string verification_uri_complete { get; set; }
        public string error { get; set; }
        public string error_description { get; set; }
    }

    class AccessResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
        public string jti { get; set; }
        public string error { get; set; }
    }

    //Get offers response
    public class Rootobject
    {
        public Offer[] offers { get; set; }
        public int count { get; set; }
        public int totalCount { get; set; }
    }

    public class Offer
    {
        public string id { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
        public Primaryimage primaryImage { get; set; }
        public Sellingmode sellingMode { get; set; }
        public Saleinfo saleInfo { get; set; }
        public Stats stats { get; set; }
        public Stock stock { get; set; }
        public Publication publication { get; set; }
        public Aftersalesservices afterSalesServices { get; set; }
        public Additionalservices additionalServices { get; set; }
        public External external { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
    }

    public class Primaryimage
    {
        public string url { get; set; }
    }

    public class Sellingmode
    {
        public string format { get; set; }
        public Price price { get; set; }
        public object minimalPrice { get; set; }
        public Startingprice startingPrice { get; set; }
    }

    public class Price
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Startingprice
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Saleinfo
    {
        public Currentprice currentPrice { get; set; }
        public int biddersCount { get; set; }
    }

    public class Currentprice
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class Stats
    {
        public int watchersCount { get; set; }
        public int visitsCount { get; set; }
    }

    public class Stock
    {
        public int available { get; set; }
        public int sold { get; set; }
    }

    public class Publication
    {
        public string status { get; set; }
        public object startingAt { get; set; }
        public string startedAt { get; set; }
        public string endingAt { get; set; }
        public string endedAt { get; set; }
    }

    public class Aftersalesservices
    {
        public Warranty warranty { get; set; }
        public Returnpolicy returnPolicy { get; set; }
        public Impliedwarranty impliedWarranty { get; set; }
    }

    public class Warranty
    {
        public string id { get; set; }
    }

    public class Returnpolicy
    {
        public string id { get; set; }
    }

    public class Impliedwarranty
    {
        public string id { get; set; }
    }

    public class Additionalservices
    {
        public string id { get; set; }
    }

    public class External
    {
        public string id { get; set; }
    }

    //Receive orders response
    public class RootobjectOrders
    {
        public CheckoutformOrders[] checkoutForms { get; set; }
        public int count { get; set; }
        public int totalCount { get; set; }
    }

    public class CheckoutformOrders
    {
        public string id { get; set; }
        public BuyerOrders buyer { get; set; }
        public PaymentOrders payment { get; set; }
        public string status { get; set; }
        public DeliveryOrders delivery { get; set; }
        public InvoiceOrders invoice { get; set; }
        public LineitemOrders[] lineItems { get; set; }
        public object[] surcharges { get; set; }
        public object[] discounts { get; set; }
        public SummaryOrders summary { get; set; }
    }

    public class BuyerOrders
    {
        public string id { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public bool guest { get; set; }
        public string phoneNumber { get; set; }
    }

    public class PaymentOrders
    {
        public string id { get; set; }
        public string type { get; set; }
        public string provider { get; set; }
        public DateTime finishedAt { get; set; }
        public PaidamountOrders paidAmount { get; set; }
    }

    public class PaidamountOrders
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class DeliveryOrders
    {
        public AddressOrders address { get; set; }
        public MethodOrders method { get; set; }
        public CostOrders cost { get; set; }
        public bool smart { get; set; }
    }

    public class AddressOrders
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string countryCode { get; set; }
        public string phoneNumber { get; set; }
    }

    public class MethodOrders
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class CostOrders
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class InvoiceOrders
    {
        public bool required { get; set; }
    }

    public class SummaryOrders
    {
        public TotaltopayOrders totalToPay { get; set; }
    }

    public class TotaltopayOrders
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class LineitemOrders
    {
        public string id { get; set; }
        public OfferOrders offer { get; set; }
        public int quantity { get; set; }
        public OriginalpriceOrders originalPrice { get; set; }
        public PriceOrders price { get; set; }
        public DateTime boughtAt { get; set; }
    }

    public class OfferOrders
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class OriginalpriceOrders
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class PriceOrders
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }


}
