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
        private int _rooms;
        private DateTime _build_date;
        private Materials _material;
        private int _floor;
        private List<Rooms> _room_options = new List<Rooms>();
        private Address _address;


        public double CalculateCost()
        {
            double totalCost = 0;


            return totalCost;
        }
    }


}
