namespace lab2
{
    public enum Countries
    {
        Belarus=0,
        Poland,
        Lithuania,
        Latvia,
        Estonia,
        Germany
    }
    public class Address
    {

        public Address() { }

        private string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        private string _district { get; set; }
        private string _street;
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        private int _building;
        public int Building
        {
            get
            {
                return _building;
            }
            set
            {
                _building = value;
            }
        }
        private int? _sub_building;
        public int? Sub_building
        {
            get
            {
                return _sub_building;
            }
            set
            {
                _sub_building = value;
            }
        }
        private int _apartment_number;
        public int Apartment_number
        {
            get
            {
                return _apartment_number;
            }
            set
            {
                _apartment_number = value;
            }
        }

        public override string ToString()
        {
            return $"country: {_country}, city: {_city}, street: {_street}, building: {_building}, sub building: {_sub_building}, apartment: {_apartment_number}";
        }


    }
}
