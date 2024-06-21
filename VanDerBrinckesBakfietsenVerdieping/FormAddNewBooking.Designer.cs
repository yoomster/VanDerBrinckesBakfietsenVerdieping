namespace VanDerBrinckesBakfietsenVerdieping
{
    partial class FormAddNewBooking
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
            CostsPerDayLabel = new Label();
            totalDaysLabel = new Label();
            ReturnDatePicker = new DateTimePicker();
            label1 = new Label();
            StartLabel = new Label();
            RentDateLlabel = new Label();
            StartDatePicker = new DateTimePicker();
            ChoiceOfBikes = new ComboBox();
            ExtrasList = new CheckedListBox();
            ButtonCalculateCost = new Button();
            TotalCostLabel = new Label();
            ExtrasLabel = new Label();
            BikeLabel = new Label();
            buttonChooseCustomer = new Button();
            SuspendLayout();
            // 
            // CostsPerDayLabel
            // 
            CostsPerDayLabel.AutoSize = true;
            CostsPerDayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CostsPerDayLabel.Location = new Point(55, 274);
            CostsPerDayLabel.Name = "CostsPerDayLabel";
            CostsPerDayLabel.Size = new Size(177, 21);
            CostsPerDayLabel.TabIndex = 25;
            CostsPerDayLabel.Text = "Kosten per dag zijn € 20";
            // 
            // totalDaysLabel
            // 
            totalDaysLabel.AutoSize = true;
            totalDaysLabel.Font = new Font("Segoe UI", 12F);
            totalDaysLabel.Location = new Point(374, 213);
            totalDaysLabel.Name = "totalDaysLabel";
            totalDaysLabel.Size = new Size(147, 21);
            totalDaysLabel.TabIndex = 24;
            totalDaysLabel.Text = "Totaal aantal dagen ";
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Font = new Font("Segoe UI", 12F);
            ReturnDatePicker.Location = new Point(374, 157);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(253, 29);
            ReturnDatePicker.TabIndex = 23;
            ReturnDatePicker.ValueChanged += ReturnDatePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(393, 133);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 22;
            label1.Text = "Eind";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("Segoe UI", 12F);
            StartLabel.Location = new Point(391, 54);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(42, 21);
            StartLabel.TabIndex = 21;
            StartLabel.Text = "Start";
            // 
            // RentDateLlabel
            // 
            RentDateLlabel.AutoSize = true;
            RentDateLlabel.Font = new Font("Segoe UI", 12F);
            RentDateLlabel.Location = new Point(374, 26);
            RentDateLlabel.Name = "RentDateLlabel";
            RentDateLlabel.Size = new Size(94, 21);
            RentDateLlabel.TabIndex = 20;
            RentDateLlabel.Text = "Huur datum";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("Segoe UI", 12F);
            StartDatePicker.Location = new Point(374, 83);
            StartDatePicker.MinDate = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(253, 29);
            StartDatePicker.TabIndex = 19;
            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            // 
            // ChoiceOfBikes
            // 
            ChoiceOfBikes.Font = new Font("Segoe UI", 12F);
            ChoiceOfBikes.FormattingEnabled = true;
            ChoiceOfBikes.Items.AddRange(new object[] { "Urban Arrow 4 pers. € 20", "Urban Arrow 6 pers. € 30", "Urban Arrow 4 pers. E-Bike € 40", "Urban Arrow 6 pers. E-Bike € 60" });
            ChoiceOfBikes.Location = new Point(55, 59);
            ChoiceOfBikes.Name = "ChoiceOfBikes";
            ChoiceOfBikes.Size = new Size(252, 29);
            ChoiceOfBikes.TabIndex = 14;
            ChoiceOfBikes.Text = "Urban Arrow 4 pers. € 20";
            ChoiceOfBikes.SelectedIndexChanged += ChoiceOfBikes_SelectedIndexChanged;
            // 
            // ExtrasList
            // 
            ExtrasList.CheckOnClick = true;
            ExtrasList.Font = new Font("Segoe UI", 12F);
            ExtrasList.FormattingEnabled = true;
            ExtrasList.Items.AddRange(new object[] { "Telefoonhouder € 5", "Helm € 10", "Regenhoes € 15", "Babystoel € 20" });
            ExtrasList.Location = new Point(55, 146);
            ExtrasList.Name = "ExtrasList";
            ExtrasList.Size = new Size(190, 100);
            ExtrasList.TabIndex = 16;
            ExtrasList.ThreeDCheckBoxes = true;
            ExtrasList.SelectedIndexChanged += ExtrasList_SelectedIndexChanged;
            // 
            // ButtonCalculateCost
            // 
            ButtonCalculateCost.Enabled = false;
            ButtonCalculateCost.Font = new Font("Segoe UI", 12F);
            ButtonCalculateCost.Location = new Point(55, 327);
            ButtonCalculateCost.Name = "ButtonCalculateCost";
            ButtonCalculateCost.Size = new Size(190, 43);
            ButtonCalculateCost.TabIndex = 18;
            ButtonCalculateCost.Text = "Bereken totale kosten";
            ButtonCalculateCost.UseVisualStyleBackColor = true;
            ButtonCalculateCost.Click += ButtonCalculateCost_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 12F);
            TotalCostLabel.Location = new Point(55, 406);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(100, 21);
            TotalCostLabel.TabIndex = 17;
            TotalCostLabel.Text = "Totale kosten";
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Font = new Font("Segoe UI", 12F);
            ExtrasLabel.Location = new Point(55, 113);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(216, 21);
            ExtrasLabel.TabIndex = 15;
            ExtrasLabel.Text = "Extras toevoegen (kosten p/d)";
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Font = new Font("Segoe UI", 12F);
            BikeLabel.Location = new Point(55, 26);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(226, 21);
            BikeLabel.TabIndex = 13;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets";
            // 
            // buttonChooseCustomer
            // 
            buttonChooseCustomer.Location = new Point(374, 274);
            buttonChooseCustomer.Name = "buttonChooseCustomer";
            buttonChooseCustomer.Size = new Size(175, 40);
            buttonChooseCustomer.TabIndex = 26;
            buttonChooseCustomer.Text = "Kies een klant";
            buttonChooseCustomer.UseVisualStyleBackColor = true;
            buttonChooseCustomer.Click += buttonChooseCustomer_Click;
            // 
            // FormAddNewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 465);
            Controls.Add(buttonChooseCustomer);
            Controls.Add(CostsPerDayLabel);
            Controls.Add(totalDaysLabel);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(StartLabel);
            Controls.Add(RentDateLlabel);
            Controls.Add(StartDatePicker);
            Controls.Add(ChoiceOfBikes);
            Controls.Add(ExtrasList);
            Controls.Add(ButtonCalculateCost);
            Controls.Add(TotalCostLabel);
            Controls.Add(ExtrasLabel);
            Controls.Add(BikeLabel);
            Name = "FormAddNewBooking";
            Text = "FormAddRental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CostsPerDayLabel;
        private Label totalDaysLabel;
        private DateTimePicker ReturnDatePicker;
        private Label label1;
        private Label StartLabel;
        private Label RentDateLlabel;
        private DateTimePicker StartDatePicker;
        private ComboBox ChoiceOfBikes;
        private CheckedListBox ExtrasList;
        private Button ButtonCalculateCost;
        private Label TotalCostLabel;
        private Label ExtrasLabel;
        private Label BikeLabel;
        private Button buttonChooseCustomer;
    }
}