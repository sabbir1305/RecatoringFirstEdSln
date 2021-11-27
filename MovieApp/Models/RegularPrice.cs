using MovieAppStart.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart.Models
{
    public class RegularPrice : Price
    {
        public override int GetPrice()
        {
            return MovieTypes.REGULAR;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
            {
                result += (daysRented - 2) * 1.5;

            }
            return result;
        }
    }
}
