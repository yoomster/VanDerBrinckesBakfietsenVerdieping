using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VanDerBrinckesBakfietsenVerdieping.Models
{
    public class VanDerBrinckesModel
    {
        public List<BookingModel> AllBookings { get; set; } = new();
        public List<CustomerModel> AllCustomers { get; set; } = new();
        public List<AccessoireModel> AllAccessoires { get; set; } = new();
        public List<BikeModel> AllBikes { get; set; } = new();
        public List<EmployeeModel> AllEmployees { get; set; } = new();




        public VanDerBrinckesModel()
        {
            AllAccessoires.Add(new AccessoireModel { Name = "Telefoonhouder", Price = 5 });
            AllAccessoires.Add(new AccessoireModel { Name = "Helm", Price = 10});
            AllAccessoires.Add(new AccessoireModel{ Name = "Regenhoes", Price = 15 });
            AllAccessoires.Add(new AccessoireModel{ Name = "Babystoel", Price = 20 });
        }
    }
}

