using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class VanDerBrinckesModel
    {
        public List<BookingModel> AllBookings { get; set; } = new();
        public List<CustomerModel> AllCustomers { get; set; } = new();
        public List<AccessoireModel> Accessoires { get; set; } = new();

        public VanDerBrinckesModel()
        {
            Accessoires.Add(new AccessoireModel("Telefoonhouder", 5));
            Accessoires.Add(new AccessoireModel("Helm", 10));
            Accessoires.Add(new AccessoireModel("Regenhoes", 15));
            Accessoires.Add(new AccessoireModel("Babystoel", 20));
        }
    }
}

