using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDerBrinckesBakfietsenVerdieping
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (userName == "nayoom" && password == "kaasje")
            {
                FormHome formHome= new FormHome();
                formHome.Show();
            }
            else
            {
                MessageBox.Show("Incorrecte inlog gegevens. Probeer opnieuw");
            }

            // uitzoeken hoe we ww *** kunnen maken ipv letters
            //this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
