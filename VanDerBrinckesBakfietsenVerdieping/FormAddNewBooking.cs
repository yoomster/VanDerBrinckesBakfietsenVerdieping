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

namespace VanDerBrinckesBakfietsenVerdieping
{
    public partial class FormAddNewBooking : Form
    {
        private readonly VanDerBrinckesModel _vanDerBrinckes;
        private BookingModel _booking = new BookingModel();


        public FormAddNewBooking(VanDerBrinckesModel vanDerBrinckes)
        {
            _vanDerBrinckes = vanDerBrinckes;

            InitializeComponent();
        }

        private void FormAddNewBooking_Load(object sender, EventArgs e)
        {
            ExtrasList.DataSource = _vanDerBrinckes.Accessoires;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;
            ReturnDatePicker.MinDate = StartDatePicker.Value.AddDays(1);

            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonCalculateCost.Enabled = true;
            }
            else
            {
                ButtonCalculateCost.Enabled = false;
            }
        }

        private void ReturnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _booking.CalculateTotalNumberOfRentDays(StartDatePicker.Value, ReturnDatePicker.Value);

            if (_booking.ValidDate == true)
            {
                totalDaysLabel.Text = $"Totaal aantal dagen is {_booking.RentDayCount}";
                ButtonCalculateCost.Enabled = true;
            }
            else
            {
                ButtonCalculateCost.Enabled = false;
            }
        }

        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            //_booking.CalculateTotalCost();
        }

        private void ExtrasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    IndexAddedExtras.Clear();

            //    for (int i = 0; i < ExtrasList.Items.Count; i++)
            //    {
            //        if (ExtrasList.GetItemChecked(i))
            //        {
            //            IndexAddedExtras.Add(i);
            //        }
            //    }
            //    CalculateExtrasCost();
            //    _vanDerBrinckes.CalculateTotalDayCost();
        }

        private void ChoiceOfBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    string bikeChoice = ChoiceOfBikes.Text;

            //    if (bikeChoice == "Urban Arrow 4 pers. € 20")
            //        MyBikeOrder.SetBikeCost(20);
            //    else if (bikeChoice == "Urban Arrow 6 pers. € 30")
            //        MyBikeOrder.SetBikeCost(30);
            //    else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
            //        MyBikeOrder.SetBikeCost(40);
            //    else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
            //        MyBikeOrder.SetBikeCost(60);
            //    CalculateTotalDayCost();
        }



        private void buttonChooseCustomer_Click(object sender, EventArgs e)
        {
            //    var FormAllCustomers = new FormViewExistingCustomers(_vanDerBrinckes);
            //    FormAllCustomers.Show();
            //}
        }


    }
}
