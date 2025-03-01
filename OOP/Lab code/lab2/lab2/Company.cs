

namespace lab2
{
    public enum CompanyType
    {
        Corparation,
        LTD,
        LLC,
        Inc
    }
    public class Company
    {
        private string _name { get; set; }
        private CompanyType _type { get; set; }
        private Address _off_address { get; set; }

        private string _company_number { get; set; }
    }
}
