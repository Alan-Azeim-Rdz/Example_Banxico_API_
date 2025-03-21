namespace Example_Banxico_API
{
    partial class Dolar_menu
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
            LblArchive = new Label();
            LblDolar = new Label();
            BtnArchive = new Button();
            BtnTable = new Button();
            BtnGrafic = new Button();
            BtnPieGrafic = new Button();
            SuspendLayout();
            // 
            // LblArchive
            // 
            LblArchive.AutoSize = true;
            LblArchive.Location = new Point(231, 103);
            LblArchive.Name = "LblArchive";
            LblArchive.Size = new Size(47, 15);
            LblArchive.TabIndex = 0;
            LblArchive.Text = "Archive";
            // 
            // LblDolar
            // 
            LblDolar.AutoSize = true;
            LblDolar.Location = new Point(499, 103);
            LblDolar.Name = "LblDolar";
            LblDolar.Size = new Size(35, 15);
            LblDolar.TabIndex = 1;
            LblDolar.Text = "Dolar";
            // 
            // BtnArchive
            // 
            BtnArchive.Location = new Point(203, 189);
            BtnArchive.Name = "BtnArchive";
            BtnArchive.Size = new Size(118, 42);
            BtnArchive.TabIndex = 2;
            BtnArchive.Text = "Exit";
            BtnArchive.UseVisualStyleBackColor = true;
            BtnArchive.Click += BtnArchive_Click;
            // 
            // BtnTable
            // 
            BtnTable.Location = new Point(388, 189);
            BtnTable.Name = "BtnTable";
            BtnTable.Size = new Size(118, 42);
            BtnTable.TabIndex = 3;
            BtnTable.Text = "Table";
            BtnTable.UseVisualStyleBackColor = true;
            BtnTable.Click += BtnTable_Click;
            // 
            // BtnGrafic
            // 
            BtnGrafic.Location = new Point(388, 309);
            BtnGrafic.Name = "BtnGrafic";
            BtnGrafic.Size = new Size(118, 42);
            BtnGrafic.TabIndex = 4;
            BtnGrafic.Text = "Grafic";
            BtnGrafic.UseVisualStyleBackColor = true;
            BtnGrafic.Click += BtnGrafic_Click;
            // 
            // BtnPieGrafic
            // 
            BtnPieGrafic.Location = new Point(549, 189);
            BtnPieGrafic.Name = "BtnPieGrafic";
            BtnPieGrafic.Size = new Size(118, 42);
            BtnPieGrafic.TabIndex = 5;
            BtnPieGrafic.Text = "Pie Grafic";
            BtnPieGrafic.UseVisualStyleBackColor = true;
            BtnPieGrafic.Click += BtnPieGrafic_Click;
            // 
            // Dolar_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 434);
            Controls.Add(BtnPieGrafic);
            Controls.Add(BtnGrafic);
            Controls.Add(BtnTable);
            Controls.Add(BtnArchive);
            Controls.Add(LblDolar);
            Controls.Add(LblArchive);
            Name = "Dolar_menu";
            Text = "Data_Dolar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblArchive;
        private Label LblDolar;
        private Button BtnArchive;
        private Button BtnTable;
        private Button BtnGrafic;
        private Button BtnPieGrafic;
    }
}