using System;

namespace lab2
{
    public class Flat
    {
        private double _square;
        private double _height;
        private int _rooms;
        private DateTime _construction_year;
        private string _material_type;
        private int _floor;
        private string _side;//west, east, etc.
        private Address _address;

       public double Square
        {
            get
            {
                return _square;
            }
            set
            {
                _square = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

        public DateTime ConstructionYear
        {
            get { return _construction_year; }
            set { _construction_year = value; }
        }

        public string MaterialType
        {
            get { return _material_type; }
            set { _material_type = value; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public string Side
        {
            get { return _side; }
            set { _side = value; }
        }

    }
}
