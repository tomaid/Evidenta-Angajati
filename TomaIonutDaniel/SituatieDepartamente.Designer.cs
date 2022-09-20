
namespace TomaIonutDaniel
{
    partial class SituatieDepartamente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSitDept = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdDept = new System.Windows.Forms.TextBox();
            this.balantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balDS = new TomaIonutDaniel.BalDS();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculDepartamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TomaIonutDaniel.DataSet1();
            this.calculDepartamenteTableAdapter = new TomaIonutDaniel.DataSet1TableAdapters.CalculDepartamenteTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.balantaTableAdapter = new TomaIonutDaniel.BalDSTableAdapters.BalantaTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepartamentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iesiriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculDepartamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSitDept
            // 
            this.lblSitDept.AutoSize = true;
            this.lblSitDept.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitDept.Location = new System.Drawing.Point(25, 12);
            this.lblSitDept.Name = "lblSitDept";
            this.lblSitDept.Size = new System.Drawing.Size(239, 26);
            this.lblSitDept.TabIndex = 0;
            this.lblSitDept.Text = "Situatie departamente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Situatie detaliată";
            // 
            // txtIdDept
            // 
            this.txtIdDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balantaBindingSource, "IdDepartament", true));
            this.txtIdDept.Location = new System.Drawing.Point(1016, 13);
            this.txtIdDept.Name = "txtIdDept";
            this.txtIdDept.Size = new System.Drawing.Size(100, 22);
            this.txtIdDept.TabIndex = 2;
            // 
            // balantaBindingSource
            // 
            this.balantaBindingSource.DataMember = "Balanta";
            this.balantaBindingSource.DataSource = this.balDS;
            this.balantaBindingSource.CurrentChanged += new System.EventHandler(this.balantaBindingSource_CurrentChanged);
            // 
            // balDS
            // 
            this.balDS.DataSetName = "BalDS";
            this.balDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.dAngajatDataGridViewTextBoxColumn,
            this.dOperatieDataGridViewTextBoxColumn,
            this.dDepartamentDataGridViewTextBoxColumn,
            this.idOperatieDataGridViewTextBoxColumn,
            this.idDepartamentDataGridViewTextBoxColumn,
            this.idAngajatDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculDepartamenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(558, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 240);
            this.dataGridView1.TabIndex = 8;
            // 
            // calculDepartamenteBindingSource
            // 
            this.calculDepartamenteBindingSource.DataMember = "CalculDepartamente";
            this.calculDepartamenteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculDepartamenteTableAdapter
            // 
            this.calculDepartamenteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentDataGridViewTextBoxColumn1,
            this.dDepartamentDataGridViewTextBoxColumn1,
            this.angajatiInitialDataGridViewTextBoxColumn,
            this.intrariDataGridViewTextBoxColumn,
            this.iesiriDataGridViewTextBoxColumn,
            this.angajatiFinalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(19, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(512, 240);
            this.dataGridView2.TabIndex = 9;
            // 
            // balantaTableAdapter
            // 
            this.balantaTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.balantaBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 312);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Distributia persoanelor pe departamente";
            series1.XValueMember = "DDepartament";
            series1.YValueMembers = "AngajatiFinal";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1136, 384);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
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
            // dAngajatDataGridViewTextBoxColumn
            // 
            this.dAngajatDataGridViewTextBoxColumn.DataPropertyName = "DAngajat";
            this.dAngajatDataGridViewTextBoxColumn.HeaderText = "Angajat";
            this.dAngajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAngajatDataGridViewTextBoxColumn.Name = "dAngajatDataGridViewTextBoxColumn";
            this.dAngajatDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAngajatDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOperatieDataGridViewTextBoxColumn
            // 
            this.dOperatieDataGridViewTextBoxColumn.DataPropertyName = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.HeaderText = "Operatie";
            this.dOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOperatieDataGridViewTextBoxColumn.Name = "dOperatieDataGridViewTextBoxColumn";
            this.dOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOperatieDataGridViewTextBoxColumn.Width = 140;
            // 
            // dDepartamentDataGridViewTextBoxColumn
            // 
            this.dDepartamentDataGridViewTextBoxColumn.DataPropertyName = "DDepartament";
            this.dDepartamentDataGridViewTextBoxColumn.HeaderText = "Departament";
            this.dDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDepartamentDataGridViewTextBoxColumn.Name = "dDepartamentDataGridViewTextBoxColumn";
            this.dDepartamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dDepartamentDataGridViewTextBoxColumn.Visible = false;
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
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Visible = false;
            this.valoareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDepartamentDataGridViewTextBoxColumn1
            // 
            this.idDepartamentDataGridViewTextBoxColumn1.DataPropertyName = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn1.HeaderText = "IdDepartament";
            this.idDepartamentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDepartamentDataGridViewTextBoxColumn1.Name = "idDepartamentDataGridViewTextBoxColumn1";
            this.idDepartamentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDepartamentDataGridViewTextBoxColumn1.Visible = false;
            this.idDepartamentDataGridViewTextBoxColumn1.Width = 94;
            // 
            // dDepartamentDataGridViewTextBoxColumn1
            // 
            this.dDepartamentDataGridViewTextBoxColumn1.DataPropertyName = "DDepartament";
            this.dDepartamentDataGridViewTextBoxColumn1.HeaderText = "Departament";
            this.dDepartamentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dDepartamentDataGridViewTextBoxColumn1.Name = "dDepartamentDataGridViewTextBoxColumn1";
            this.dDepartamentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dDepartamentDataGridViewTextBoxColumn1.Width = 90;
            // 
            // angajatiInitialDataGridViewTextBoxColumn
            // 
            this.angajatiInitialDataGridViewTextBoxColumn.DataPropertyName = "AngajatiInitial";
            this.angajatiInitialDataGridViewTextBoxColumn.HeaderText = "Angajati Initial";
            this.angajatiInitialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.angajatiInitialDataGridViewTextBoxColumn.Name = "angajatiInitialDataGridViewTextBoxColumn";
            this.angajatiInitialDataGridViewTextBoxColumn.ReadOnly = true;
            this.angajatiInitialDataGridViewTextBoxColumn.Width = 60;
            // 
            // intrariDataGridViewTextBoxColumn
            // 
            this.intrariDataGridViewTextBoxColumn.DataPropertyName = "Intrari";
            this.intrariDataGridViewTextBoxColumn.HeaderText = "Intrari";
            this.intrariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intrariDataGridViewTextBoxColumn.Name = "intrariDataGridViewTextBoxColumn";
            this.intrariDataGridViewTextBoxColumn.ReadOnly = true;
            this.intrariDataGridViewTextBoxColumn.Width = 60;
            // 
            // iesiriDataGridViewTextBoxColumn
            // 
            this.iesiriDataGridViewTextBoxColumn.DataPropertyName = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.HeaderText = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iesiriDataGridViewTextBoxColumn.Name = "iesiriDataGridViewTextBoxColumn";
            this.iesiriDataGridViewTextBoxColumn.ReadOnly = true;
            this.iesiriDataGridViewTextBoxColumn.Width = 60;
            // 
            // angajatiFinalDataGridViewTextBoxColumn
            // 
            this.angajatiFinalDataGridViewTextBoxColumn.DataPropertyName = "AngajatiFinal";
            this.angajatiFinalDataGridViewTextBoxColumn.HeaderText = "Angajati in data curenta";
            this.angajatiFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.angajatiFinalDataGridViewTextBoxColumn.Name = "angajatiFinalDataGridViewTextBoxColumn";
            this.angajatiFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.angajatiFinalDataGridViewTextBoxColumn.Width = 60;
            // 
            // SituatieDepartamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 714);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIdDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSitDept);
            this.Name = "SituatieDepartamente";
            this.Text = "Situatie Departamente";
            this.Load += new System.EventHandler(this.SituatieDepartamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculDepartamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSitDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdDept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculDepartamenteBindingSource;
        private DataSet1TableAdapters.CalculDepartamenteTableAdapter calculDepartamenteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BalDS balDS;
        private System.Windows.Forms.BindingSource balantaBindingSource;
        private BalDSTableAdapters.BalantaTableAdapter balantaTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepartamentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn angajatiInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iesiriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angajatiFinalDataGridViewTextBoxColumn;
    }
}