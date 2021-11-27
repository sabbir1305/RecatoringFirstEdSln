using MovieAppStart.Configurations;
using MovieAppStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart.Factory
{
   public class PriceFactory 
    {
     
        public static Price GetMoviePrice(int movieType)
        {
            Price _price;
            switch (movieType)
            {
                case MovieTypes.REGULAR:
                    _price = new RegularPrice();
                    break;
                case MovieTypes.NEW_RELEASE:
                    _price = new NewReleasePrice();
                    break;
                case MovieTypes.CHILDRENS:
                    _price = new ChildrensPrice();
                    break;
                default:
                    throw new Exception("Inccorect price code");
            }
            return _price;
        }
    }
}
