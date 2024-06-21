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
        public double DailyCostAccessoires { get; set; }
        public double TotalCostAccessoires { get; set; }
        public double TotalCostBike { get;  set; }



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

        public void CalculateCostsAccessoires(List<AccessoireModel> accessoires)
        {
            int extrasCost = 0;

            //check alleen selected index!!!

            foreach (var index in accessoires)
            {
                if (accessoires.IndexOf() == 0)
                    DailyCostAccessoires += 5;
                else if (index == 1)
                    DailyCostAccessoires += 10;
                else if (index == 2)
                    DailyCostAccessoires += 15;
                else if (index == 3)
                    DailyCostAccessoires += 20;
            }
        }


        public void CalculateTotalCost(List<BikeModel> bikes )
        {
            TotalCostBike = 0;

            foreach (var selectedItem in bikes)
            {


            }

            TotalCostBike += TotalCostAccessoires;
        }
    }
}
