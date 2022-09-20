
namespace TomaIonutDaniel
{
    partial class RaportDemisii
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RaportDemisiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TomaIonutDaniel.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RaportDemisiiTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.RaportDemisiiTableAdapter();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RaportDemisiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // RaportDemisiiBindingSource
            // 
            this.RaportDemisiiBindingSource.DataMember = "RaportDemisii";
            this.RaportDemisiiBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSDemisii";
            reportDataSource1.Value = this.RaportDemisiiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TomaIonutDaniel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(713, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // RaportDemisiiTableAdapter
            // 
            this.RaportDemisiiTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(175, 22);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(120, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(322, 22);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 2;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectati luna si anul: ";
            // 
            // RaportDemisii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportDemisii";
            this.Text = "Demisii";
            this.Load += new System.EventHandler(this.RaportDemisii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaportDemisiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RaportDemisiiBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.RaportDemisiiTableAdapter RaportDemisiiTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Label label1;
    }
}