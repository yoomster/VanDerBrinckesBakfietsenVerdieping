namespace VanDerBrinckesBakfietsenVerdieping
{
    partial class FormLogin
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
            buttonOk = new Button();
            buttonCancel = new Button();
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(223, 131);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(109, 45);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(82, 131);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 45);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(56, 35);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(96, 15);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Gebruikersnaam:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(56, 74);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(81, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Wachtwoord: ";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(183, 35);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(183, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(183, 74);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(183, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 207);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
    }
}