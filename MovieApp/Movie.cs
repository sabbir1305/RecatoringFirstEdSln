using MovieAppStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart
{
    public class Movie
    {
        public const     int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        private String _title;
        private Price _price;

        public Movie(String title, int priceCode)
        {
            _title = title;
            setPriceCode(priceCode);
        }
        public int getPriceCode()
        {
            return _price.GetPrice();
        }
        private void setPriceCode(int arg)
        {
            switch (arg)
            {
                case REGULAR:
                    _price = new RegularPrice();
                    break;
                case NEW_RELEASE:
                    _price = new NewReleasePrice();
                    break;
                case CHILDRENS:
                    _price = new ChildrensPrice();
                    break;
                default:
                    throw new Exception("Inccorect price code");
            }
        }
        public String getTitle()
        {
            return _title;
        }

        public double GetCharge(int daysRented)
        {
            
            return _price.GetCharge(daysRented);
        }

        public int GetFrequuentRentalPoints(int daysRented)
        {
            return _price.GetFrequuentRentalPoints(daysRented);
        }

    }
}
