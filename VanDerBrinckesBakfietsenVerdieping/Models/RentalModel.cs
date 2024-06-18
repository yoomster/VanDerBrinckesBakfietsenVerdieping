using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class RentalModel
    {
        public double TotalCostBike { get; ; }
        public double DailyCostExtras { get; set; }
        public double TotalCostExtras{ get; set; }
        public int NumberOfRentDays { get; set; }
    }
}
