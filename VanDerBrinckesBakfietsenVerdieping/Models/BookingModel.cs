using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class BookingModel
    {
        public int RentDayCount { get; set; } = 0;
        public bool ValidDate { get; set; } = false;
        public List<AccessoireModel> Accessoires { get; set; }
        public double DailyCostExtras { get; set; }
        public double TotalCostExtras { get; set; }
        public double TotalCostBike
        {
            set
            {
                TotalCostExtras += value;
            }
        }



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



        public void CalculateTotalCost(List<AccessoireModel> accessoires)
        {
            int extrasCost = 0;
            var index = 0;

            foreach (var selectedItem in accessoires)
            {
                if (index == 0)
                    extrasCost += 5;
                else if (index == 1)
                    extrasCost += 10;
                else if (index == 2)
                    extrasCost += 15;
                else if (index == 3)
                    extrasCost += 20;
            }

            TotalCostExtras += (extrasCost);
        }
    }
}
