using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MovieAppStart
{
   public class Customer
    {
        private String _name;
        private IList<Rental> _rentals = new List<Rental>();


        public Customer(String name)
        {
            _name = name;
        }
        public void addRental(Rental arg)
        {
            _rentals.Add(arg);
        }
        public String getName()
        {
            return _name;
        }

        public String statement()
        {

    
            var rentals = _rentals.GetEnumerator();
            String result = "Rental Record for " + getName() + ":";
            while (rentals.MoveNext())
            {
                Rental each = rentals.Current;             
                result += " " + each.getMovie().getTitle() + "  " +
                each.GetCharge() + ",";

            }
            //add footer lines
            result += "Amount owed is " + GetTotalChareged() + ".";
            result += "You earned " + GetTotalFrequentPoints ()+ " frequent renter points";
            return result;
        }


        public string HtmlStatement()
        {
            var rentals = _rentals.GetEnumerator();
            StringBuilder builder = new StringBuilder();
            builder.Append($"<h1>Rentals for <em>{getName()}</em></h1>\n<p>");
            while (rentals.MoveNext())
            {
                Rental each = rentals.Current;
                builder.Append($"{each.getMovie().getTitle()} : {each.GetCharge()}\n");
            }

            builder.Append($"</p><p>You ower {GetTotalChareged()}</p>");
            builder.Append($"<p>On this rental you earned {GetTotalFrequentPoints()} refrer rental points.</p>");
            return builder.ToString();
           }


        private double GetTotalChareged()
        {
            
            double result = 0;
            var rentals = _rentals.GetEnumerator();
            while (rentals.MoveNext())
            {

                Rental each = rentals.Current;

                result += each.GetCharge();
            }

            return result;

        }

        private int GetTotalFrequentPoints()
        {
            int result = 0;
            var rentals = _rentals.GetEnumerator();
            while (rentals.MoveNext())
            {

                Rental each = rentals.Current;
                result += each.GetFrequuentRentalPoints();

            }

            return result;

        }

 

    }


}
