using MovieAppStart;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesTestCh1
{
    [TestFixture]
    public class TestCustomer
    {

        [Test]
        public void TestCustomerStateMent()
        {
            string expectedResult = @"Rental Record for Sabbir: Thor  15, IronMan  2,Amount owed is 17.You earned 3 frequent renter points";
            Movie thor = new Movie("Thor", 1);
            Movie ironMan = new Movie("IronMan", 0);
            Customer _customer = new Customer("Sabbir");
            _customer.addRental(new Rental (thor,5));
            _customer.addRental(new Rental (ironMan, 2));
            var result = _customer.statement();
            Assert.IsTrue(result == expectedResult);


        }


    }
}

