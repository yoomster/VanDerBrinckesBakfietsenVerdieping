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
            buttonAllRentals = new Button();
            buttonNewBooking = new Button();
            buttonAllCustomers = new Button();
            buttonNewCustomer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAllRentals
            // 
            buttonAllRentals.Location = new Point(349, 102);
            buttonAllRentals.Name = "buttonAllRentals";
            buttonAllRentals.Size = new Size(175, 57);
            buttonAllRentals.TabIndex = 0;
            buttonAllRentals.Text = "Alle boekingen";
            buttonAllRentals.UseVisualStyleBackColor = true;
            // 
            // buttonNewBooking
            // 
            buttonNewBooking.Location = new Point(349, 190);
            buttonNewBooking.Name = "buttonNewBooking";
            buttonNewBooking.Size = new Size(175, 57);
            buttonNewBooking.TabIndex = 1;
            buttonNewBooking.Text = "Nieuwe boeking";
            buttonNewBooking.UseVisualStyleBackColor = true;
            // 
            // buttonAllCustomers
            // 
            buttonAllCustomers.Location = new Point(74, 102);
            buttonAllCustomers.Name = "buttonAllCustomers";
            buttonAllCustomers.Size = new Size(175, 57);
            buttonAllCustomers.TabIndex = 2;
            buttonAllCustomers.Text = "Alle klanten";
            buttonAllCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.Location = new Point(74, 190);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(175, 57);
            buttonNewCustomer.TabIndex = 3;
            buttonNewCustomer.Text = "Nieuwe klant";
            buttonNewCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 54);
            label1.Name = "label1";
            label1.Size = new Size(251, 15);
            label1.TabIndex = 4;
            label1.Text = "Welkom {adminName}, dit is de home pagina.";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 302);
            Controls.Add(label1);
            Controls.Add(buttonNewCustomer);
            Controls.Add(buttonAllCustomers);
            Controls.Add(buttonNewBooking);
            Controls.Add(buttonAllRentals);
            Name = "FormHome";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAllRentals;
        private Button buttonNewBooking;
        private Button buttonAllCustomers;
        private Button buttonNewCustomer;
        private Label label1;
    }
}