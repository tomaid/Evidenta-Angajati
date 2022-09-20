
namespace TomaIonutDaniel
{
    partial class Departamente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.gvDepartamente = new System.Windows.Forms.DataGridView();
            this.idDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TomaIonutDaniel.DataSet1();
            this.txtIdDept = new System.Windows.Forms.TextBox();
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.angajatiPeDepartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamenteTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.DepartamenteTableAdapter();
            this.angajatiPeDepartTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.AngajatiPeDepartTableAdapter();
            this.dAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartamente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiPeDepartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamente";
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(186, 12);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(100, 39);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(186, 12);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(114, 39);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(306, 12);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(114, 39);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // gvDepartamente
            // 
            this.gvDepartamente.AllowUserToAddRows = false;
            this.gvDepartamente.AllowUserToDeleteRows = false;
            this.gvDepartamente.AutoGenerateColumns = false;
            this.gvDepartamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartamente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentDataGridViewTextBoxColumn,
            this.dDepartamentDataGridViewTextBoxColumn});
            this.gvDepartamente.DataSource = this.departamenteBindingSource;
            this.gvDepartamente.Location = new System.Drawing.Point(18, 64);
            this.gvDepartamente.Name = "gvDepartamente";
            this.gvDepartamente.ReadOnly = true;
            this.gvDepartamente.RowHeadersWidth = 51;
            this.gvDepartamente.RowTemplate.Height = 24;
            this.gvDepartamente.Size = new System.Drawing.Size(420, 374);
            this.gvDepartamente.TabIndex = 4;
            this.gvDepartamente.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDepartamente_CellMouseDoubleClick);
            this.gvDepartamente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDepartamente_CellValueChanged);
            this.gvDepartamente.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvDepartamente_DataError);
            this.gvDepartamente.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvDepartamente_UserDeletingRow);
            this.gvDepartamente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gvDepartamente_MouseDoubleClick);
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
            // dDepartamentDataGridViewTextBoxColumn
            // 
            this.dDepartamentDataGridViewTextBoxColumn.DataPropertyName = "DDepartament";
            this.dDepartamentDataGridViewTextBoxColumn.HeaderText = "Departament";
            this.dDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDepartamentDataGridViewTextBoxColumn.Name = "dDepartamentDataGridViewTextBoxColumn";
            this.dDepartamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDepartamentDataGridViewTextBoxColumn.Width = 250;
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "Departamente";
            this.departamenteBindingSource.DataSource = this.dataSet1;
            this.departamenteBindingSource.CurrentChanged += new System.EventHandler(this.departamenteBindingSource_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdDept
            // 
            this.txtIdDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamenteBindingSource, "IdDepartament", true));
            this.txtIdDept.Location = new System.Drawing.Point(563, 20);
            this.txtIdDept.Name = "txtIdDept";
            this.txtIdDept.Size = new System.Drawing.Size(100, 22);
            this.txtIdDept.TabIndex = 5;
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.AllowUserToAddRows = false;
            this.dgvAngajati.AllowUserToDeleteRows = false;
            this.dgvAngajati.AutoGenerateColumns = false;
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAngajatDataGridViewTextBoxColumn,
            this.idAngajatDataGridViewTextBoxColumn,
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idDepartamentDataGridViewTextBoxColumn1});
            this.dgvAngajati.DataSource = this.angajatiPeDepartBindingSource;
            this.dgvAngajati.Location = new System.Drawing.Point(483, 64);
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.ReadOnly = true;
            this.dgvAngajati.RowHeadersWidth = 51;
            this.dgvAngajati.RowTemplate.Height = 24;
            this.dgvAngajati.Size = new System.Drawing.Size(369, 374);
            this.dgvAngajati.TabIndex = 6;
            // 
            // angajatiPeDepartBindingSource
            // 
            this.angajatiPeDepartBindingSource.DataMember = "AngajatiPeDepart";
            this.angajatiPeDepartBindingSource.DataSource = this.dataSet1;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiPeDepartTableAdapter
            // 
            this.angajatiPeDepartTableAdapter.ClearBeforeFill = true;
            // 
            // dAngajatDataGridViewTextBoxColumn
            // 
            this.dAngajatDataGridViewTextBoxColumn.DataPropertyName = "DAngajat";
            this.dAngajatDataGridViewTextBoxColumn.HeaderText = "Angajati in departament";
            this.dAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAngajatDataGridViewTextBoxColumn.Name = "dAngajatDataGridViewTextBoxColumn";
            this.dAngajatDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAngajatDataGridViewTextBoxColumn.Width = 200;
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Visible = false;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDepartamentDataGridViewTextBoxColumn1
            // 
            this.idDepartamentDataGridViewTextBoxColumn1.DataPropertyName = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn1.HeaderText = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDepartamentDataGridViewTextBoxColumn1.Name = "idDepartamentDataGridViewTextBoxColumn1";
            this.idDepartamentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDepartamentDataGridViewTextBoxColumn1.Visible = false;
            this.idDepartamentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Departamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.dgvAngajati);
            this.Controls.Add(this.txtIdDept);
            this.Controls.Add(this.gvDepartamente);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.label1);
            this.Name = "Departamente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Departamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartamente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiPeDepartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView gvDepartamente;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private DataSet1TableAdapters.DepartamenteTableAdapter departamenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIdDept;
        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.BindingSource angajatiPeDepartBindingSource;
        private DataSet1TableAdapters.AngajatiPeDepartTableAdapter angajatiPeDepartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn1;
    }
}