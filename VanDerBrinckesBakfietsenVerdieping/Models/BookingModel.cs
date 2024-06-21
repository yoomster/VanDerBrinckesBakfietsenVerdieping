using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class BookingModel
    {
        public double TotalCostBike
        {
            set
            {
                TotalCostExtras += value;
            }
        }
        public double DailyCostExtras { get; set; }
        public double TotalCostExtras { get; set; }
        public int RentDayCount { get; set; } = 0;
        public bool ValidDate { get; set; } = false;
        public List<AccessoireModel> Accessoires { get; set; }

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
    }
}
