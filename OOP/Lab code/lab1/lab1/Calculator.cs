using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{

    public static class Calculator
    {
        private enum Coverings
        {
            Parket = 1,
            Plitka,
            Lominat 
        }

        private static readonly double lominat_length_metres = 1.5;
        private static readonly double lominat_width_metres = 0.3;
        private static readonly double lominat_length_feet = 4.91;
        private static readonly double lominat_width_feet = 0.98;

        private static readonly double parket_length_metres = 1.0;
        private static readonly double parket_width_metres = 0.2;
        private static readonly double parket_length_feet = 3.28;
        private static readonly double parket_width_feet = 0.656;

        private static readonly double plitka_measure_metres = 0.7;
        private static readonly double plitka_measure_feet = 2.296;

        private static readonly double oboi_roulet_length_metres = 10;
        private static readonly double oboi_roulet_width_metres = 1.0;
        private static readonly double oboi_roulet_length_feet = 32.8;
        private static readonly double oboi_roulet_width_feet = 3.28;

        
        public static int CalculateOboiMetres(double width, double length, double height)
        {
           
            double lengthSquare = length * height;
            double widthSquare = width * height;
            double singleOboiSquare = oboi_roulet_length_metres * oboi_roulet_width_metres;

            int rouletsForLength = (int)(lengthSquare / singleOboiSquare)*2;
            int rouletsForWIdth = (int)(widthSquare / singleOboiSquare) * 2;

            return rouletsForLength + rouletsForWIdth;
        }

        public static double CalculateOboiFeet(double width, double length, double height)
        {
            double lengthSquare = length * height;
            double widthSquare = width * height;
            double singleOboiSquare = oboi_roulet_length_feet * oboi_roulet_width_feet;

            double rouletsForLength = (lengthSquare / singleOboiSquare) * 2;
            double rouletsForWIdth = (widthSquare / singleOboiSquare) * 2;

            return Math.Round((rouletsForLength+rouletsForWIdth),2);
        }

        public static int CalculatePlitkaMetres(double width, double length)
        {
            double roomSquare = width * length;

            double singlePlitkaSquare = plitka_measure_metres * plitka_measure_metres;

            return (int)(roomSquare/singlePlitkaSquare);
        }

        public static int CalculatePlitkaFeet(double width, double length)
        {
            double roomSquare = width * length;
            double singlePlitkaSquare = plitka_measure_feet * plitka_measure_feet;
            return (int)(roomSquare/singlePlitkaSquare);
        }

        public static int CalculateParketMetres(double width,double length)
        {
            double roomSquare = width * length;
            double singleParketSquare = parket_length_metres * parket_width_metres;
            return (int)(roomSquare/singleParketSquare);
        }

        public static int CalculateParketFeet(double width,double length)
        {
            double roomSquare = width * length;
            double singleParketSquare = parket_length_feet * parket_width_feet;
            return (int)(roomSquare / singleParketSquare);
        }

        public static int CalculateLominatMetres(double length,double width)
        {
            double roomSquare = width * length;
            double singleLominatSquare = lominat_length_metres * lominat_width_metres;

            return (int)(roomSquare/singleLominatSquare);
        }

        public static int CalculateLominatFeet(double length,double width)
        {
            double roomSquare = width * length;
            double singleLominatSquare = lominat_length_feet * lominat_width_feet;

            return (int)(roomSquare / singleLominatSquare);
        }


        public static double CalulateRoomSquare(double square, double height)
        {
            double roomVolume = square * height;
            return Math.Round(roomVolume);
        }
    }
}
