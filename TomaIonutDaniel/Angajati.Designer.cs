
namespace TomaIonutDaniel
{
    partial class Angajati
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
            this.lblAngajati = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TomaIonutDaniel.DataSet1();
            this.angajatiTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.AngajatiTableAdapter();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.operatiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamenteTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.DepartamenteTableAdapter();
            this.operatiiTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.OperatiiTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.idAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAngajati
            // 
            this.lblAngajati.AutoSize = true;
            this.lblAngajati.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngajati.Location = new System.Drawing.Point(24, 30);
            this.lblAngajati.Name = "lblAngajati";
            this.lblAngajati.Size = new System.Drawing.Size(109, 33);
            this.lblAngajati.TabIndex = 0;
            this.lblAngajati.Text = "Angajați";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAngajatDataGridViewTextBoxColumn,
            this.dAngajatDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(241, 30);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(106, 33);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(515, 30);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(106, 33);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(377, 30);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(106, 33);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // operatiiBindingSource
            // 
            this.operatiiBindingSource.DataMember = "Operatii";
            this.operatiiBindingSource.DataSource = this.dataSet1;
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "Departamente";
            this.departamenteBindingSource.DataSource = this.dataSet1;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // operatiiTableAdapter
            // 
            this.operatiiTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 513);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 9;
            // 
            // idAngajatDataGridViewTextBoxColumn
            // 
            this.idAngajatDataGridViewTextBoxColumn.DataPropertyName = "IdAngajat";
            this.idAngajatDataGridViewTextBoxColumn.HeaderText = "IdAngajat";
            this.idAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAngajatDataGridViewTextBoxColumn.Name = "idAngajatDataGridViewTextBoxColumn";
            this.idAngajatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAngajatDataGridViewTextBoxColumn.Visible = false;
            this.idAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // dAngajatDataGridViewTextBoxColumn
            // 
            this.dAngajatDataGridViewTextBoxColumn.DataPropertyName = "DAngajat";
            this.dAngajatDataGridViewTextBoxColumn.HeaderText = "Nume angajat";
            this.dAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAngajatDataGridViewTextBoxColumn.Name = "dAngajatDataGridViewTextBoxColumn";
            this.dAngajatDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAngajatDataGridViewTextBoxColumn.Width = 250;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPDataGridViewTextBoxColumn.Width = 150;
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 452);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAngajati);
            this.Name = "Angajati";
            this.Text = "Angajati";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAngajati;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private DataSet1TableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private DataSet1TableAdapters.DepartamenteTableAdapter departamenteTableAdapter;
        private System.Windows.Forms.BindingSource operatiiBindingSource;
        private DataSet1TableAdapters.OperatiiTableAdapter operatiiTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
    }
}