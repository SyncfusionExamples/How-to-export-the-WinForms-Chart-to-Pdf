using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            Panel panel = new Panel();

            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.SuspendLayout();
            panel.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.IsWindowLess = false;            
            this.chartControl1.TabIndex = 0;            
            this.chartControl1.Skins = Skins.Metro;
           
            //
            // PrimaryXAxis
            //
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            
            chartSeries1 = new ChartSeries();
            chartSeries1.Type = ChartSeriesType.Column;
            chartSeries1.Style.DisplayText = true;
            chartSeries1.Style.TextOrientation = ChartTextOrientation.Up;

            chartSeries1.Points.Add(1, 15);
            chartSeries1.Points.Add(2, 12);
            chartSeries1.Points.Add(3, 18);
            chartSeries1.Points.Add(4, 22);
            chartSeries1.Points.Add(5, 15);
            this.chartControl1.Series.Add(chartSeries1);
           
                
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Size = new System.Drawing.Size(700, 450);
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 577);

          //  this.chartControl1.ShowToolbar = true;
            panel.AutoSize = true;
            panel.Controls.Add(chartControl1);
            this.Controls.Add(panel);

            string fileName = Application.StartupPath + "\\chartExport";

            string exportFileName = fileName + ".pdf";
            string file = fileName + ".gif";
            this.chartControl1.SaveImage(file);

            //Create a PDF document
            PdfDocument pdfDoc = new PdfDocument();

            //Add a page to the empty PDF document
            pdfDoc.Pages.Add();

            //Draw chart image in the first page
            pdfDoc.Pages[0].Graphics.DrawImage(PdfImage.FromFile(file), new PointF(0, 10));

            //Save the PDF Document to disk.
            pdfDoc.Save(exportFileName);

            // Launches the file.
            System.Diagnostics.Process.Start(exportFileName);

            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}

