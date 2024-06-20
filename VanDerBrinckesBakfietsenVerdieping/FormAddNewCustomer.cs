using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanDerBrinckesBakfietsenVerdieping.Models;

namespace VanDerBrinckesBakfietsenVerdieping
{
    public partial class FormAddNewCustomer : Form
    {
        private readonly VanDerBrinckesModel _vanDerBrinckes;


        public FormAddNewCustomer(VanDerBrinckesModel vanDerBrinckes)
        {
            _vanDerBrinckes = vanDerBrinckes;

            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CustomerModel person = new CustomerModel
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Address = textBoxAddress.Text,
                HouseNumber = textBoxHouseNumber.Text,
                Zipcode = textBoxZipcode.Text,
                City = textBoxCity.Text,
                Comments = textBoxComments.Text
            };

            //validatie mogelijk in model ipv 6 ifjes hiero?

            if (string.IsNullOrEmpty(person.FirstName) || 
                string.IsNullOrEmpty(person.LastName) || 
                string.IsNullOrEmpty(person.Address) ||
                string.IsNullOrEmpty(person.HouseNumber) ||
                string.IsNullOrEmpty(person.Zipcode) ||
                string.IsNullOrEmpty(person.City))
            {
                MessageBox.Show("incorrect, je mist persoonsinformatie");
            }
            else 
            {
                _vanDerBrinckes.AllCustomers.Add(person);

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
