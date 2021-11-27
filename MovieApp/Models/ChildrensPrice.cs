using MovieAppStart.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart.Models
{
    public class ChildrensPrice : Price
    {
        public override int GetPrice()
        {
            return MovieTypes.CHILDRENS;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if(daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;

            }
            return result;
        }
    }
}
