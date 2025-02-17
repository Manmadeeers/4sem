using System;

namespace lab2
{
    public class Address
    {
        private string _country;
        private string _city;
        private string _district;
        private string _street;
        private string _building;
        private string _sub_building;
        private int _flat_number;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string District
        {
            get { return _district; }
            set { _district = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string Building
        {
            get { return _building; }
            set { _building = value; }
        }

        public string SubBuilding
        {
            get { return _sub_building; }
            set { _sub_building = value; }
        }

        public int FlatNumber
        {
            get { return _flat_number; }
            set { _flat_number = value; }
        }
    }
}
