using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class QuoteTotal
    {
        public decimal MaxQuote()
        {
            Insuree insuree = new Insuree();
            decimal quoteTotal = 50;
            var today = DateTime.Today;
            var age = today.Year - insuree.DateOfBirth.Year;
            if (age <= 18)
            {
                quoteTotal += 100;
            }
            if (age >= 19 && age <= 25)
            {
                quoteTotal += +50;
            }
            if (age > 25)
            {
                quoteTotal += +25;
            }
            if (insuree.CarYear < 2000)
            {
                quoteTotal += +25;
            }
            if (insuree.CarYear > 2015)
            {
                quoteTotal += +25;
            }
            if (insuree.CarMake == "Porsche")
            {
                quoteTotal += +25;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                quoteTotal += +25;
            }
            if (insuree.SpeedingTickets > 0)
            {
                decimal h = insuree.SpeedingTickets * 10;
                quoteTotal += h;
            }
            if (insuree.DUI == true)
            {
                quoteTotal *= 1.25m;
            }
            if (insuree.CoverageType == true)
            {
                quoteTotal *= 1.5m;
            }

            insuree.Quote = quoteTotal;
            return insuree.Quote;
        }
    }
}