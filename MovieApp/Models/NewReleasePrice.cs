using MovieAppStart.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart.Models
{
    public class NewReleasePrice : Price
    {
        public override int GetPrice()
        {
            return MovieTypes.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequuentRentalPoints(int daysRented)
        {
            return (daysRented > 1) ? 2 : 1;
        }
    }
}
