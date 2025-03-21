namespace Example_Banxico_API
{
    partial class Pie_chart
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
            FormPlotPieFromValues = new ScottPlot.WinForms.FormsPlot();
            FromPlotPiePercent = new ScottPlot.WinForms.FormsPlot();
            BtnGenerate = new Button();
            LblFinal = new Label();
            FromPlotDonut = new ScottPlot.WinForms.FormsPlot();
            FromPlotPieDifferentLabels = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // FormPlotPieFromValues
            // 
            FormPlotPieFromValues.DisplayScale = 1F;
            FormPlotPieFromValues.Location = new Point(702, 12);
            FormPlotPieFromValues.Name = "FormPlotPieFromValues";
            FormPlotPieFromValues.Size = new Size(339, 324);
            FormPlotPieFromValues.TabIndex = 21;
            // 
            // FromPlotPiePercent
            // 
            FromPlotPiePercent.DisplayScale = 1F;
            FromPlotPiePercent.Location = new Point(324, 12);
            FromPlotPiePercent.Name = "FromPlotPiePercent";
            FromPlotPiePercent.Size = new Size(339, 324);
            FromPlotPiePercent.TabIndex = 20;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(108, 295);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(75, 23);
            BtnGenerate.TabIndex = 19;
            BtnGenerate.Text = "generar";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // LblFinal
            // 
            LblFinal.AutoSize = true;
            LblFinal.Location = new Point(90, 260);
            LblFinal.Name = "LblFinal";
            LblFinal.Size = new Size(111, 15);
            LblFinal.TabIndex = 16;
            LblFinal.Text = "generador de tablas";
            // 
            // FromPlotDonut
            // 
            FromPlotDonut.DisplayScale = 1F;
            FromPlotDonut.Location = new Point(1076, 12);
            FromPlotDonut.Name = "FromPlotDonut";
            FromPlotDonut.Size = new Size(339, 324);
            FromPlotDonut.TabIndex = 22;
            // 
            // FromPlotPieDifferentLabels
            // 
            FromPlotPieDifferentLabels.DisplayScale = 1F;
            FromPlotPieDifferentLabels.Location = new Point(702, 342);
            FromPlotPieDifferentLabels.Name = "FromPlotPieDifferentLabels";
            FromPlotPieDifferentLabels.Size = new Size(339, 324);
            FromPlotPieDifferentLabels.TabIndex = 23;
            // 
            // Pie_chart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 676);
            Controls.Add(FromPlotPieDifferentLabels);
            Controls.Add(FromPlotDonut);
            Controls.Add(FormPlotPieFromValues);
            Controls.Add(FromPlotPiePercent);
            Controls.Add(BtnGenerate);
            Controls.Add(LblFinal);
            Name = "Pie_chart";
            Text = "Pie_chart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot FormPlotPieFromValues;
        private ScottPlot.WinForms.FormsPlot FromPlotPiePercent;
        private Button BtnGenerate;
        private Label LblFinal;
        private ScottPlot.WinForms.FormsPlot FromPlotDonut;
        private ScottPlot.WinForms.FormsPlot FromPlotPieDifferentLabels;
    }
}