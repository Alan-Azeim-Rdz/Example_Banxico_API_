namespace Example_Banxico_API
{
    partial class Grafica_de_datos
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
            BtnEnter = new Button();
            DataTimeFinal = new DateTimePicker();
            DataTimeInicio = new DateTimePicker();
            LblFinal = new Label();
            LblInicio = new Label();
            FromPlotDataDolar = new ScottPlot.WinForms.FormsPlot();
            FormPlotBarriel = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new Point(108, 284);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(75, 23);
            BtnEnter.TabIndex = 11;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // DataTimeFinal
            // 
            DataTimeFinal.Format = DateTimePickerFormat.Custom;
            DataTimeFinal.Location = new Point(108, 198);
            DataTimeFinal.Name = "DataTimeFinal";
            DataTimeFinal.Size = new Size(231, 23);
            DataTimeFinal.TabIndex = 10;
            // 
            // DataTimeInicio
            // 
            DataTimeInicio.Format = DateTimePickerFormat.Custom;
            DataTimeInicio.Location = new Point(108, 122);
            DataTimeInicio.Name = "DataTimeInicio";
            DataTimeInicio.Size = new Size(231, 23);
            DataTimeInicio.TabIndex = 9;
            // 
            // LblFinal
            // 
            LblFinal.AutoSize = true;
            LblFinal.Location = new Point(108, 180);
            LblFinal.Name = "LblFinal";
            LblFinal.Size = new Size(139, 15);
            LblFinal.TabIndex = 8;
            LblFinal.Text = "final date of consultation";
            // 
            // LblInicio
            // 
            LblInicio.AutoSize = true;
            LblInicio.Location = new Point(108, 104);
            LblInicio.Name = "LblInicio";
            LblInicio.Size = new Size(131, 15);
            LblInicio.TabIndex = 7;
            LblInicio.Text = "initial consultation date";
            // 
            // FromPlotDataDolar
            // 
            FromPlotDataDolar.DisplayScale = 1F;
            FromPlotDataDolar.Location = new Point(386, 46);
            FromPlotDataDolar.Name = "FromPlotDataDolar";
            FromPlotDataDolar.Size = new Size(456, 405);
            FromPlotDataDolar.TabIndex = 13;
            // 
            // FormPlotBarriel
            // 
            FormPlotBarriel.DisplayScale = 1F;
            FormPlotBarriel.Location = new Point(887, 46);
            FormPlotBarriel.Name = "FormPlotBarriel";
            FormPlotBarriel.Size = new Size(456, 405);
            FormPlotBarriel.TabIndex = 14;
            // 
            // Grafica_de_datos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 610);
            Controls.Add(FormPlotBarriel);
            Controls.Add(FromPlotDataDolar);
            Controls.Add(BtnEnter);
            Controls.Add(DataTimeFinal);
            Controls.Add(DataTimeInicio);
            Controls.Add(LblFinal);
            Controls.Add(LblInicio);
            Name = "Grafica_de_datos";
            Text = "Grafica_de_datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnEnter;
        private DateTimePicker DataTimeFinal;
        private DateTimePicker DataTimeInicio;
        private Label LblFinal;
        private Label LblInicio;
        private ScottPlot.WinForms.FormsPlot FromPlotDataDolar;
        private ScottPlot.WinForms.FormsPlot FormPlotBarriel;
    }
}