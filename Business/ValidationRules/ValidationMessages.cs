namespace Business.ValidationRules;

public static class ValidationMessages
{
    // Product Validator
    public static string ProductNameEmpty = "Ürün adı boş bırakılamaz.";
    public static string ProductNameLength = "Ürün adı minumum 2, maksimum 50 karakterden oluşabilir.";
    public static string ProductMarketPriceGreater = "Ürün market satış fiyatı 1'e eşit veya büyük olmalıdır.";
    public static string ProductSellPriceGreater = "Ürün satış fiyati 1'e eşit veya büyük olmalıdır.";
    public static string ProductVATPercent = "Ürün KDV oranı %10 veya %20 olmalıdır.";
    public static string ProductQuantity = "Ürün miktarı 1'e eşit veya büyük olmalıdır.";
    public static string ProductVATPrice = "Ürün KDV dahil satış fiyatı 1'e eşit veya büyük olmalıdır.";


    // Customer Validator
    public static string CustomerNameEmpty = "Cari adı boş bırakılamaz.";
    public static string CustomerNameLength = "Cari adı minumum 2, maksimum 50 karakterden oluşabilir.";
    public static string CustomerSurnameEmpty = "Cari soyadı boş bırakılamaz.";
    public static string CustomerSurnameLength = "Cari soyadı minumum 2, maksimum 50 karakterden oluşabilir.";
    public static string CustomerPhone = "Cari telefon numarası boş bırakılamaz.";
    public static string CustomerTaxNo = "Cari Vergi Numarası 10 haneden oluşmalıdır.";


    // Bill Validator
    public static string BillHasToBeSaleToAdd = "Fatura oluşturmak için en az 1 adet satış lazım.";

    // Sale Validator
    public static string SaleCustomerCantBeEmpty = "Cari boş bırakılamaz.";
    public static string SaleProductCantBeEmpty = "Ürün boş bırakılamaz";
    public static string SaleQuantityCantBeEmpty = "Miktar boş bırakılamaz";
    public static string SaleQuantityGreaterThan = "Miktar 1'e eşit veya büyük olmalıdır.";
    public static string SalePriceGreaterThan = "Tutar 1'e eşit veya büyük olmalıdır.";
    public static string SalePaymentMethodCantBeEmpty = "Ödeme Yöntemi boş bırakılamaz";
}
