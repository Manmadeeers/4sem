

using System.ComponentModel.DataAnnotations;

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
        private string _name;

        [Required(ErrorMessage="Name is required")]
        [RegularExpression(@"[a-zA-Z0-9]$",ErrorMessage ="Company name field can take only letters and numbers")]
        public string Name
        {
            get;set;
        }
        private CompanyType _type;
        public CompanyType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

       
        private string _off_address;

        [RegularExpression(@"[a-zA-z0-9]$",ErrorMessage ="Oficial address field can take only letters and numbers")]
        [Required(ErrorMessage = "Address is required")]
        public string Off_address
        {
            get;set;
        }

        private string _company_number;

        [Required(ErrorMessage ="Company number is required")]
        [RegularExpression(@"[a-zA-Z0-9]$",ErrorMessage ="Company number field can take only letters and numbers")]
        public string Company_number
        {
            get;set;
        }

        public override string ToString()
        {
            return $"Name: {_name}, type: {_type}, official address: {_off_address}, company number: {_company_number}";
        }
    }
}
