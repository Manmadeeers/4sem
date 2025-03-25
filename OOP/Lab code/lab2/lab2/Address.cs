using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage ="Country is required")]
        public string Country
        {
            get;set;
        }

        private string _city;

        [Required(ErrorMessage = "City is required")]
        [RegularExpression(@"[a-zA-Z]+$",ErrorMessage ="City name field can take only letters")]
        public string City
        {
            get;set;
        }
        private string _district { get; set; }

        private string _street;

        [Required(ErrorMessage ="Street is required")]
        [RegularExpression(@"[a-zA-Z0-9]+$",ErrorMessage ="Street name field can take only letters and numbers")]
        public string Street
        {
            get;set;
        }

        private int _building;

        [Required(ErrorMessage="Building is required")]
        public int Building
        {
            get;set;
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

        [Required(ErrorMessage ="Apartment number is required")]
        public int Apartment_number
        {
            get;set;
        }

        public override string ToString()
        {
            return $"country: {_country}, city: {_city}, street: {_street}, building: {_building}, sub building: {_sub_building}, apartment: {_apartment_number}";
        }


    }
}
