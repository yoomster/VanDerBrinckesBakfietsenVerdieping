namespace VanDerBrinckesBakfietsenVerdieping
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAllBookings = new Button();
            buttonNewBooking = new Button();
            buttonAllCustomers = new Button();
            buttonNewCustomer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAllBookings
            // 
            buttonAllBookings.Location = new Point(290, 85);
            buttonAllBookings.Name = "buttonAllBookings";
            buttonAllBookings.Size = new Size(141, 57);
            buttonAllBookings.TabIndex = 0;
            buttonAllBookings.Text = "Alle boekingen";
            buttonAllBookings.UseVisualStyleBackColor = true;
            buttonAllBookings.Click += buttonAllBookings_Click;
            // 
            // buttonNewBooking
            // 
            buttonNewBooking.Location = new Point(290, 173);
            buttonNewBooking.Name = "buttonNewBooking";
            buttonNewBooking.Size = new Size(141, 57);
            buttonNewBooking.TabIndex = 1;
            buttonNewBooking.Text = "Nieuwe boeking";
            buttonNewBooking.UseVisualStyleBackColor = true;
            buttonNewBooking.Click += buttonNewBooking_Click;
            // 
            // buttonAllCustomers
            // 
            buttonAllCustomers.Location = new Point(56, 85);
            buttonAllCustomers.Name = "buttonAllCustomers";
            buttonAllCustomers.Size = new Size(146, 57);
            buttonAllCustomers.TabIndex = 2;
            buttonAllCustomers.Text = "Alle klanten";
            buttonAllCustomers.UseVisualStyleBackColor = true;
            buttonAllCustomers.Click += buttonAllCustomers_Click;
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.Location = new Point(56, 173);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(146, 57);
            buttonNewCustomer.TabIndex = 3;
            buttonNewCustomer.Text = "Nieuwe klant";
            buttonNewCustomer.UseVisualStyleBackColor = true;
            buttonNewCustomer.Click += buttonNewCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 4;
            label1.Text = "Welkom Naomi, dit is de Admin home pagina ";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 269);
            Controls.Add(label1);
            Controls.Add(buttonNewCustomer);
            Controls.Add(buttonAllCustomers);
            Controls.Add(buttonNewBooking);
            Controls.Add(buttonAllBookings);
            Name = "FormHome";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAllBookings;
        private Button buttonNewBooking;
        private Button buttonAllCustomers;
        private Button buttonNewCustomer;
        private Label label1;
    }
}