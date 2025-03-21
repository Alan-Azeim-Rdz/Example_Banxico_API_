namespace Example_Banxico_API
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnExit = new Button();
            BtnGetInto = new Button();
            TextBoxPassword = new TextBox();
            TextBoxUser = new TextBox();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(183, 382);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(137, 37);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += button1_Click;
            // 
            // BtnGetInto
            // 
            BtnGetInto.Location = new Point(557, 382);
            BtnGetInto.Name = "BtnGetInto";
            BtnGetInto.Size = new Size(137, 37);
            BtnGetInto.TabIndex = 1;
            BtnGetInto.Text = "Enter";
            BtnGetInto.UseVisualStyleBackColor = true;
            BtnGetInto.Click += BtnGetInto_Click;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(212, 231);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.Size = new Size(466, 23);
            TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxUser
            // 
            TextBoxUser.Location = new Point(212, 164);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.Size = new Size(466, 23);
            TextBoxUser.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 558);
            Controls.Add(TextBoxUser);
            Controls.Add(TextBoxPassword);
            Controls.Add(BtnGetInto);
            Controls.Add(BtnExit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit;
        private Button BtnGetInto;
        private TextBox TextBoxPassword;
        private TextBox TextBoxUser;
    }
}
