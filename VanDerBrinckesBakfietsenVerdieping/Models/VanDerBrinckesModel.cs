using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class VanDerBrinckesModel
    {
        public List<BookingModel> AllBookings { get; set; } = new();

        public List<CustomerModel> AllCustomers { get; set; } = new();


    }
}
