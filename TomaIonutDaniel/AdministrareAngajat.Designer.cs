
namespace TomaIonutDaniel
{
    partial class AdministrareAngajat
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
            this.cbDemisionat = new System.Windows.Forms.CheckBox();
            this.lblAdministrare = new System.Windows.Forms.Label();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartament = new System.Windows.Forms.ComboBox();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TomaIonutDaniel.DataSet1();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurnalAngajatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblJurnal = new System.Windows.Forms.Label();
            this.jurnalAngajatTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.JurnalAngajatTableAdapter();
            this.departamenteTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.DepartamenteTableAdapter();
            this.angajatiTableAdapter1 = new TomaIonutDaniel.DataSet1TableAdapters.AngajatiTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalAngajatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDemisionat
            // 
            this.cbDemisionat.AutoSize = true;
            this.cbDemisionat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDemisionat.Location = new System.Drawing.Point(18, 241);
            this.cbDemisionat.Name = "cbDemisionat";
            this.cbDemisionat.Size = new System.Drawing.Size(206, 24);
            this.cbDemisionat.TabIndex = 31;
            this.cbDemisionat.Text = "Concediat / Demisionat";
            this.cbDemisionat.UseVisualStyleBackColor = true;
            // 
            // lblAdministrare
            // 
            this.lblAdministrare.AutoSize = true;
            this.lblAdministrare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrare.Location = new System.Drawing.Point(12, 18);
            this.lblAdministrare.Name = "lblAdministrare";
            this.lblAdministrare.Size = new System.Drawing.Size(159, 33);
            this.lblAdministrare.TabIndex = 30;
            this.lblAdministrare.Text = "Administrare";
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(165, 292);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(106, 33);
            this.btnRenuntare.TabIndex = 29;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(15, 292);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(106, 33);
            this.btnSalvare.TabIndex = 28;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(11, 202);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 22);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data";
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartament.Location = new System.Drawing.Point(11, 154);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(110, 22);
            this.lblDepartament.TabIndex = 26;
            this.lblDepartament.Text = "Departament";
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(87, 201);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(185, 22);
            this.dateTP.TabIndex = 25;
            // 
            // cmbDepartament
            // 
            this.cmbDepartament.DataSource = this.departamenteBindingSource;
            this.cmbDepartament.DisplayMember = "DDepartament";
            this.cmbDepartament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartament.FormattingEnabled = true;
            this.cmbDepartament.Location = new System.Drawing.Point(127, 155);
            this.cmbDepartament.Name = "cmbDepartament";
            this.cmbDepartament.Size = new System.Drawing.Size(144, 24);
            this.cmbDepartament.TabIndex = 24;
            this.cmbDepartament.ValueMember = "IdDepartament";
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "Departamente";
            this.departamenteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(86, 113);
            this.txtCNP.MaxLength = 13;
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(186, 22);
            this.txtCNP.TabIndex = 23;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNP.Location = new System.Drawing.Point(11, 113);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(48, 22);
            this.lblCNP.TabIndex = 22;
            this.lblCNP.Text = "CNP";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(11, 73);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(56, 22);
            this.lblNume.TabIndex = 21;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(86, 73);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(186, 22);
            this.txtNume.TabIndex = 20;
            this.txtNume.Leave += new System.EventHandler(this.txtNume_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAngajatDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dDepartamentDataGridViewTextBoxColumn,
            this.idOperatieDataGridViewTextBoxColumn,
            this.idDepartamentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jurnalAngajatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 252);
            this.dataGridView1.TabIndex = 32;
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DOperatie";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dDepartamentDataGridViewTextBoxColumn
            // 
            this.dDepartamentDataGridViewTextBoxColumn.DataPropertyName = "DDepartament";
            this.dDepartamentDataGridViewTextBoxColumn.HeaderText = "Departament";
            this.dDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDepartamentDataGridViewTextBoxColumn.Name = "dDepartamentDataGridViewTextBoxColumn";
            this.dDepartamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperatieDataGridViewTextBoxColumn.Visible = false;
            this.idOperatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDepartamentDataGridViewTextBoxColumn
            // 
            this.idDepartamentDataGridViewTextBoxColumn.DataPropertyName = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn.HeaderText = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDepartamentDataGridViewTextBoxColumn.Name = "idDepartamentDataGridViewTextBoxColumn";
            this.idDepartamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepartamentDataGridViewTextBoxColumn.Visible = false;
            this.idDepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurnalAngajatBindingSource
            // 
            this.jurnalAngajatBindingSource.DataMember = "JurnalAngajat";
            this.jurnalAngajatBindingSource.DataSource = this.dataSet1;
            // 
            // lblJurnal
            // 
            this.lblJurnal.AutoSize = true;
            this.lblJurnal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurnal.Location = new System.Drawing.Point(309, 22);
            this.lblJurnal.Name = "lblJurnal";
            this.lblJurnal.Size = new System.Drawing.Size(145, 27);
            this.lblJurnal.TabIndex = 33;
            this.lblJurnal.Text = "Jurnal angajat";
            // 
            // jurnalAngajatTableAdapter
            // 
            this.jurnalAngajatTableAdapter.ClearBeforeFill = true;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiTableAdapter1
            // 
            this.angajatiTableAdapter1.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 412);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 22);
            this.txtId.TabIndex = 34;
            // 
            // AdministrareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 350);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblJurnal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDemisionat);
            this.Controls.Add(this.lblAdministrare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.cmbDepartament);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Name = "AdministrareAngajat";
            this.Text = "Administrare angajat";
            this.Load += new System.EventHandler(this.AdministrareAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalAngajatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDemisionat;
        private System.Windows.Forms.Label lblAdministrare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.ComboBox cmbDepartament;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.MaskedTextBox txtNume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblJurnal;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.JurnalAngajatTableAdapter jurnalAngajatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private DataSet1TableAdapters.DepartamenteTableAdapter departamenteTableAdapter;
        private DataSet1TableAdapters.AngajatiTableAdapter angajatiTableAdapter1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource jurnalAngajatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn;
    }
}