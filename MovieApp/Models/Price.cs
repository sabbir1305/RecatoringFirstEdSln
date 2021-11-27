using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart.Models
{
   public abstract class Price
    {
        public abstract int GetPrice();
        public abstract double GetCharge(int daysRented);
        public virtual int GetFrequuentRentalPoints(int daysRented)
        {
            
            return 1;
        }

    }
}
