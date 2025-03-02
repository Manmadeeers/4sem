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
        private DateTime _build_date { get; set; }
        private Materials _material { get; set; }
        private int _floor { get; set; }
        private List<Rooms> _room_options = new List<Rooms>();
        private Address _address { get; set; }
        private Company _company { get; set; }


        public double CalculateCost()
        {
            double totalCost = 0;


            return totalCost;
        }
    }


}
