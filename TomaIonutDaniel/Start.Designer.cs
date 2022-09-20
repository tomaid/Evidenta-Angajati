
namespace TomaIonutDaniel
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminDepartamente = new System.Windows.Forms.Button();
            this.btnAdmAngajati = new System.Windows.Forms.Button();
            this.btnSituatieDepartamente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlegeti = new System.Windows.Forms.Label();
            this.dtpLunaAn = new System.Windows.Forms.DateTimePicker();
            this.btnDemisii = new System.Windows.Forms.Button();
            this.btnAngajari = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidenta angajati";
            // 
            // btnAdminDepartamente
            // 
            this.btnAdminDepartamente.Location = new System.Drawing.Point(21, 76);
            this.btnAdminDepartamente.Name = "btnAdminDepartamente";
            this.btnAdminDepartamente.Size = new System.Drawing.Size(182, 75);
            this.btnAdminDepartamente.TabIndex = 1;
            this.btnAdminDepartamente.Text = "Administrare departamente";
            this.btnAdminDepartamente.UseVisualStyleBackColor = true;
            this.btnAdminDepartamente.Click += new System.EventHandler(this.btnAdminDepartamente_Click);
            // 
            // btnAdmAngajati
            // 
            this.btnAdmAngajati.Location = new System.Drawing.Point(224, 76);
            this.btnAdmAngajati.Name = "btnAdmAngajati";
            this.btnAdmAngajati.Size = new System.Drawing.Size(182, 75);
            this.btnAdmAngajati.TabIndex = 2;
            this.btnAdmAngajati.Text = "Administrare  angajati";
            this.btnAdmAngajati.UseVisualStyleBackColor = true;
            this.btnAdmAngajati.Click += new System.EventHandler(this.btnAdmAngajati_Click);
            // 
            // btnSituatieDepartamente
            // 
            this.btnSituatieDepartamente.Location = new System.Drawing.Point(253, 19);
            this.btnSituatieDepartamente.Name = "btnSituatieDepartamente";
            this.btnSituatieDepartamente.Size = new System.Drawing.Size(97, 38);
            this.btnSituatieDepartamente.TabIndex = 3;
            this.btnSituatieDepartamente.Text = "Afisare";
            this.btnSituatieDepartamente.UseVisualStyleBackColor = true;
            this.btnSituatieDepartamente.Click += new System.EventHandler(this.btnSituatieDepartamente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlegeti);
            this.groupBox1.Controls.Add(this.dtpLunaAn);
            this.groupBox1.Controls.Add(this.btnSituatieDepartamente);
            this.groupBox1.Location = new System.Drawing.Point(21, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situatie lunara pe departamente";
            // 
            // lblAlegeti
            // 
            this.lblAlegeti.AutoSize = true;
            this.lblAlegeti.Location = new System.Drawing.Point(6, 30);
            this.lblAlegeti.Name = "lblAlegeti";
            this.lblAlegeti.Size = new System.Drawing.Size(82, 17);
            this.lblAlegeti.TabIndex = 5;
            this.lblAlegeti.Text = "Alegeti luna";
            // 
            // dtpLunaAn
            // 
            this.dtpLunaAn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLunaAn.CustomFormat = "MM/yyyy";
            this.dtpLunaAn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLunaAn.Location = new System.Drawing.Point(113, 30);
            this.dtpLunaAn.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpLunaAn.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpLunaAn.Name = "dtpLunaAn";
            this.dtpLunaAn.ShowUpDown = true;
            this.dtpLunaAn.Size = new System.Drawing.Size(104, 22);
            this.dtpLunaAn.TabIndex = 4;
            // 
            // btnDemisii
            // 
            this.btnDemisii.Location = new System.Drawing.Point(224, 272);
            this.btnDemisii.Name = "btnDemisii";
            this.btnDemisii.Size = new System.Drawing.Size(182, 54);
            this.btnDemisii.TabIndex = 5;
            this.btnDemisii.Text = "Raport demisii";
            this.btnDemisii.UseVisualStyleBackColor = true;
            this.btnDemisii.Click += new System.EventHandler(this.btnDemisii_Click);
            // 
            // btnAngajari
            // 
            this.btnAngajari.Location = new System.Drawing.Point(21, 272);
            this.btnAngajari.Name = "btnAngajari";
            this.btnAngajari.Size = new System.Drawing.Size(182, 54);
            this.btnAngajari.TabIndex = 6;
            this.btnAngajari.Text = "Raport angajari";
            this.btnAngajari.UseVisualStyleBackColor = true;
            this.btnAngajari.Click += new System.EventHandler(this.btnAngajari_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 401);
            this.Controls.Add(this.btnAngajari);
            this.Controls.Add(this.btnDemisii);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdmAngajati);
            this.Controls.Add(this.btnAdminDepartamente);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Evidenta angajati";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminDepartamente;
        private System.Windows.Forms.Button btnAdmAngajati;
        private System.Windows.Forms.Button btnSituatieDepartamente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpLunaAn;
        private System.Windows.Forms.Label lblAlegeti;
        private System.Windows.Forms.Button btnDemisii;
        private System.Windows.Forms.Button btnAngajari;
    }
}

