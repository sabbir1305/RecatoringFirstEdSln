using MovieAppStart.Configurations;
using MovieAppStart.Factory;
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
        private void setPriceCode(int movieType)
        {
            _price = PriceFactory.GetMoviePrice(movieType);
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
