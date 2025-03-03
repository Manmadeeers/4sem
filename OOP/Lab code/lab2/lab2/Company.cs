

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
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
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
        public string Off_address
        {
            get
            {
                return _off_address;
            }
            set
            {
                _off_address = value;
            }
        }

        private string _company_number;
        public string Company_number
        {
            get
            {
                return _company_number;
            }
            set
            {
                _company_number = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {_name}, type: {_type}, official address: {_off_address}, company number: {_company_number}";
        }
    }
}
