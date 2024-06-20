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
    public partial class FormAddNewBooking : Form
    {
        private readonly VanDerBrinckesModel _vanDerBrinckes;


        public FormAddNewBooking(VanDerBrinckesModel vanDerBrinckes)
        {
                _vanDerBrinckes = vanDerBrinckes;

                InitializeComponent();
        }

        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {

        }
    }
}
