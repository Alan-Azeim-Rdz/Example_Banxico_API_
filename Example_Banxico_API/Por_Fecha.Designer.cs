namespace Example_Banxico_API
{
    partial class Por_Fecha
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
            LblInicio = new Label();
            LblFinal = new Label();
            DataTimeInicio = new DateTimePicker();
            DataTimeFinal = new DateTimePicker();
            BtnEnter = new Button();
            DataGrideDataDolar = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Dolar_Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGrideDataDolar).BeginInit();
            SuspendLayout();
            // 
            // LblInicio
            // 
            LblInicio.AutoSize = true;
            LblInicio.Location = new Point(74, 65);
            LblInicio.Name = "LblInicio";
            LblInicio.Size = new Size(131, 15);
            LblInicio.TabIndex = 0;
            LblInicio.Text = "initial consultation date";
            // 
            // LblFinal
            // 
            LblFinal.AutoSize = true;
            LblFinal.Location = new Point(74, 141);
            LblFinal.Name = "LblFinal";
            LblFinal.Size = new Size(139, 15);
            LblFinal.TabIndex = 1;
            LblFinal.Text = "final date of consultation";
            // 
            // DataTimeInicio
            // 
            DataTimeInicio.Format = DateTimePickerFormat.Custom;
            DataTimeInicio.Location = new Point(74, 83);
            DataTimeInicio.Name = "DataTimeInicio";
            DataTimeInicio.Size = new Size(231, 23);
            DataTimeInicio.TabIndex = 2;
            // 
            // DataTimeFinal
            // 
            DataTimeFinal.Format = DateTimePickerFormat.Custom;
            DataTimeFinal.Location = new Point(74, 159);
            DataTimeFinal.Name = "DataTimeFinal";
            DataTimeFinal.Size = new Size(231, 23);
            DataTimeFinal.TabIndex = 3;
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new Point(74, 245);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(75, 23);
            BtnEnter.TabIndex = 5;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // DataGrideDataDolar
            // 
            DataGrideDataDolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideDataDolar.Columns.AddRange(new DataGridViewColumn[] { Fecha, Dolar_Precio });
            DataGrideDataDolar.Location = new Point(382, 39);
            DataGrideDataDolar.Name = "DataGrideDataDolar";
            DataGrideDataDolar.Size = new Size(498, 454);
            DataGrideDataDolar.TabIndex = 6;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de consulta";
            Fecha.Name = "Fecha";
            // 
            // Dolar_Precio
            // 
            Dolar_Precio.HeaderText = "Precio del Dolar";
            Dolar_Precio.Name = "Dolar_Precio";
            // 
            // Por_Fecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 551);
            Controls.Add(DataGrideDataDolar);
            Controls.Add(BtnEnter);
            Controls.Add(DataTimeFinal);
            Controls.Add(DataTimeInicio);
            Controls.Add(LblFinal);
            Controls.Add(LblInicio);
            Name = "Por_Fecha";
            Text = "Pof_Fecha";
            ((System.ComponentModel.ISupportInitialize)DataGrideDataDolar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblInicio;
        private Label LblFinal;
        private DateTimePicker DataTimeInicio;
        private DateTimePicker DataTimeFinal;
        private Button BtnEnter;
        private DataGridView DataGrideDataDolar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Dolar_Precio;
    }
}