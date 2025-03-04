using System;
using System.Collections.Generic;

namespace lab2
{
    public enum Materials
    {
        Brick,
        Concrete,
        Wood
    }

    public enum Rooms
    {
        Kitchen,
        Toilet,
        Basement,
        Balcony,
        LivingRoom,
    }
    public class Flat
    {
        private double _square;
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
        private int _rooms;
        public int Rooms
        {
            get
            {
                return _rooms;
            }
            set
            {
                _rooms = value;
            }
        }
        private DateTime _build_date;
        public DateTime BuildDate
        {
            get
            {
                return _build_date;
            }
            set
            {
                _build_date = value;
            }
        }
        private Materials _material;
        public Materials Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }
        private int _floor;
        public int Floor
        {
            get
            {
                return _floor;
            }
            set
            {
                _floor = value;
            }
        }
        private int _room_options;
        public int RoomOptions
        {
            get
            {
                return _room_options;
            }
            set
            {
                _room_options = value;
            }
        }
        private Address _address = new Address();
        public Address Address
        {
            get
            {
                return this._address;
            }
            set
            {
                _address = value;
            }
        }
        private Company _company = new Company();
        public Company Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value; 
            }
        }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }


        public double CalculateCost()
        {
            double totalCost = 0;

            double defaultMeterPrice = 500;

            totalCost += defaultMeterPrice * this.Square;
            totalCost *= 1 + (double)Rooms / 10;
            if (BuildDate <= new DateTime(2010, 1, 1))
            {
                totalCost *= 0.9;
            }
            else
            {
                totalCost *= 1.5;
            }

            if (Floor > 10)
            {
                totalCost *= 1.5;
            }
            else
            {
                totalCost *= 0.9;
            }
            totalCost *= 1 + (double)RoomOptions / 10;
            return totalCost;
        }

        public override string ToString()
        {
            return $"{this.Address.Country}-{this.Address.City}-{this.Address.Street}-{this.Address.Sub_building}-{this.Address.Building}-{this.Address.Apartment_number}\n" +
                $"{this.Square} square metres; {this.Rooms} rooms; was built {this.BuildDate}; Made out of {this.Material}\n" +
                $"Built by {this.Company.Name}; {this.Company.Company_number}; {this.Company.Off_address}; {this.Company.Type}\n" +
                $"Costs:{this.Price}\n" +
                $"<-------------------->";
        }
    }


}
