using System;

namespace lab2
{
    public enum Cities
    {
        Gomel = 1,
        Mogilev,
        Vitebsk,
        Brest,
        Grodno,
        Minsk
    }
    public class Address
    {
        private string _country;
        private Cities _city;
        private string _district;
        private string _street;
        private int _building;
        private string _sub_building = null;
        private int _flat_number;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public Cities City
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

        public int Building
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
