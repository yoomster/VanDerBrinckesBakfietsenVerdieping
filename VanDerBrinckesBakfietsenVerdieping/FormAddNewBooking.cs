using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanDerBrinckesBakfietsenVerdieping.Models;
using static System.Windows.Forms.CheckedListBox;

namespace VanDerBrinckesBakfietsenVerdieping
{
    public partial class FormAddNewBooking : Form
    {
        private readonly VanDerBrinckesModel _vanDerBrinckes;
        private BookingModel _booking = new ();

        public FormAddNewBooking(VanDerBrinckesModel vanDerBrinckes)
        {
            _vanDerBrinckes = vanDerBrinckes;
            InitializeComponent();
        }

        private void FormAddNewBooking_Load(object sender, EventArgs e)
        {
            ListBoxAccessoires.DataSource = _vanDerBrinckes.AllAccessoires;

            //OR if issues with datasource
            //foreach (var item in _vanDerBrinckes.Accessoires)
            //{
            //    ExtrasList.Items.Add(item);
            //}
        }
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;
            ReturnDatePicker.MinDate = StartDatePicker.Value.AddDays(1);

            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }
        }

        private void ReturnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _booking.Accessoires.Clear();

            foreach (AccessoireModel item in ListBoxAccessoires.CheckedItems)
            {
                _booking.Accessoires.Add(item);
            }

            _booking.CalculateTotalCost();
            MessageBox.Show($"Total costs are {_booking.TotalRentalCost}");

            //_vanDerBrinckes.AddBooking(); of bij employee
            //new Serialization().SaveToJson(_vanDerBrinckes);

            this.Close();
        }

        private void ChoiceOfBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //grab selected bike
            //put in the ChosenBike prop
            //Take cost and put this inside the PriceBike prop ?? kan dit?

            //int selectedIndex = ChoiceOfBikes.SelectedIndex;

            string bikeChoice = ChoiceOfBikes.Text;

            if (bikeChoice == "Urban Arrow 4 pers. € 20")
                _booking.CostBike = 20;
            else if (bikeChoice == "Urban Arrow 6 pers. € 30")
                _booking.CostBike = 30;
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                _booking.CostBike = 40;
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                _booking.CostBike = 60;
        }

        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            //    var FormAllCustomers = new FormViewExistingCustomers(_vanDerBrinckes);
            //    FormAllCustomers.Show();
            //}
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
