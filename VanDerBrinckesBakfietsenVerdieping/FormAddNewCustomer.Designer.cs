namespace VanDerBrinckesBakfietsenVerdieping
{
    partial class FormAddNewCustomer
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
            buttonSave = new Button();
            buttonCancel = new Button();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            textBoxHouseNumber = new TextBox();
            labelHouseNumber = new Label();
            labelZipcode = new Label();
            textBoxZipcode = new TextBox();
            labelCity = new Label();
            textBoxCity = new TextBox();
            textBoxComments = new TextBox();
            labelComment = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(220, 303);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 45);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Opslaan";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(52, 303);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(104, 45);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Annuleer";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(106, 25);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "Voornaam: ";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(208, 22);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(208, 65);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(106, 68);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(78, 15);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Achternaam: ";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(106, 103);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(73, 15);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Straatnaam: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(208, 100);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 3;
            // 
            // textBoxHouseNumber
            // 
            textBoxHouseNumber.Location = new Point(208, 138);
            textBoxHouseNumber.Name = "textBoxHouseNumber";
            textBoxHouseNumber.Size = new Size(100, 23);
            textBoxHouseNumber.TabIndex = 4;
            // 
            // labelHouseNumber
            // 
            labelHouseNumber.AutoSize = true;
            labelHouseNumber.Location = new Point(106, 141);
            labelHouseNumber.Name = "labelHouseNumber";
            labelHouseNumber.Size = new Size(80, 15);
            labelHouseNumber.TabIndex = 9;
            labelHouseNumber.Text = "Huisnummer:";
            // 
            // labelZipcode
            // 
            labelZipcode.AutoSize = true;
            labelZipcode.Location = new Point(106, 177);
            labelZipcode.Name = "labelZipcode";
            labelZipcode.Size = new Size(62, 15);
            labelZipcode.TabIndex = 10;
            labelZipcode.Text = "Postcode: ";
            // 
            // textBoxZipcode
            // 
            textBoxZipcode.Location = new Point(208, 174);
            textBoxZipcode.Name = "textBoxZipcode";
            textBoxZipcode.Size = new Size(100, 23);
            textBoxZipcode.TabIndex = 5;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(106, 209);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(36, 15);
            labelCity.TabIndex = 12;
            labelCity.Text = "Stad: ";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(208, 206);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(100, 23);
            textBoxCity.TabIndex = 6;
            // 
            // textBoxComments
            // 
            textBoxComments.Location = new Point(208, 248);
            textBoxComments.Name = "textBoxComments";
            textBoxComments.Size = new Size(100, 23);
            textBoxComments.TabIndex = 13;
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(106, 251);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(86, 15);
            labelComment.TabIndex = 14;
            labelComment.Text = "Opmerkingen: ";
            // 
            // FormAddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 359);
            Controls.Add(textBoxComments);
            Controls.Add(labelComment);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxZipcode);
            Controls.Add(labelZipcode);
            Controls.Add(labelHouseNumber);
            Controls.Add(textBoxHouseNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormAddNewCustomer";
            Text = "Nieuwe klant toevoegen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private TextBox textBoxHouseNumber;
        private Label labelHouseNumber;
        private Label labelZipcode;
        private TextBox textBoxZipcode;
        private Label labelCity;
        private TextBox textBoxCity;
        private TextBox textBoxComments;
        private Label labelComment;
    }
}