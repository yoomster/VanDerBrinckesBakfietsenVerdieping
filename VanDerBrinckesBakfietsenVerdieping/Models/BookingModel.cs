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
        public BikeModel ChosenBike { get; set; }
        public double TotalCostAccessoires { get; set; }
        public double PriceAccessoires
        {
            get
            {
                double price = 0;
                price += Accessoires.Sum(i => i.Price);
                double totalPrice = price * RentDayCount;

                return totalPrice;
            }
        }
        public double CostBike { get; set; } = 20; // inaccurate ; need to * RentDayCount 

        public double PriceBike
        {
            get
            {
                double price = 0;
                double totalPrice = price * RentDayCount;

                return totalPrice;
            }
        }
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

        public void CalculateCostsBike() // kunnen we dit skippen zoals de accessoires?
        {
            CostBike *= RentDayCount;
        }

        public void CalculateTotalCost()
        {
            CalculateCostsBike();

            TotalRentalCost = PriceAccessoires + CostBike;
        }
    }
}
