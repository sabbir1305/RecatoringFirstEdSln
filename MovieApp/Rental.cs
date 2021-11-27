﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart
{
    public class Rental
    {
        private Movie _movie;
        private int _daysRented;
        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            _daysRented = daysRented;
        }
        public int getDaysRented()
        {
            return _daysRented;
        }
        public Movie getMovie()
        {
            return _movie;
        }

        public double GetCharge()
        {
            
            return _movie.GetCharge(_daysRented);
        }

        public  int GetFrequuentRentalPoints()
        {
            return _movie.GetFrequuentRentalPoints(_daysRented);
        }

    }
}
