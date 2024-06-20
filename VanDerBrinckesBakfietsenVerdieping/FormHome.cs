using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanDerBrinckesBakfietsenVerdieping.Models;

namespace VanDerBrinckesBakfietsenVerdieping
{
    public partial class FormHome : Form
    {
        private VanDerBrinckesModel _vanDerBrinckes = new VanDerBrinckesModel();

        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonAllCustomers_Click(object sender, EventArgs e)
        {
            var FormAllCustomers = new FormViewExistingCustomers(_vanDerBrinckes);
            FormAllCustomers.Show();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            var FormNewCustomer = new FormAddNewCustomer(_vanDerBrinckes);
            FormNewCustomer.Show();
        }

        private void buttonAllBookings_Click(object sender, EventArgs e)
        {
            var FormAllBookings = new FormViewExistingBookings(_vanDerBrinckes);
            FormAllBookings.Show();
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            var FormNewBooking = new FormAddNewBooking(_vanDerBrinckes);
            FormNewBooking.Show();
        }
    }
}
