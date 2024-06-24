using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class BookingModel
    {
        public int RentDayCount { get; set; } = 0;
        public bool ValidDate { get; set; } = false;
        public List<AccessoireModel> Accessoires { get; set; } = new();
        public double TotalCostAccessoires { get; set; }
        public double PriceAccessoires
        {
            get
            {
                double price = 0;
                price += Accessoires.Sum(i => i.Price);
                double totalPrice = price * RentDayCount;

                return price + totalPrice;
            }
        }
        public double TotalCostBike { get; set; } = 20; // inaccurate ; need to * RentDayCount 
        public double TotalRentalCost { get; set; }



        public void CalculateTotalNumberOfRentDays(DateTime start, DateTime end)
        {
            DateTime startDate = start;
            DateTime returnDate = end;

            TimeSpan difference = returnDate - startDate;

            RentDayCount = (int)Math.Ceiling(difference.TotalDays);

            if (RentDayCount <= 0)
            {
                MessageBox.Show("Error, foutieve invoer");
                ValidDate = false;
            }
            else
            {
                ValidDate = true;
            }
        }

        public void CalculateCostsAccessoires()
        {
            foreach (AccessoireModel accessoire in Accessoires)
            {
                TotalCostAccessoires += accessoire.Price;
            }
        }

        public void CalculateTotalCost()
        {
            TotalRentalCost = PriceAccessoires + TotalCostBike;
        }
    }
}
