using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class Departamente : Form
    {
        const int IdDepartamentIndex = 0;
        const int DDepartamentIndex = 1;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader r;
        public Departamente()
        {
            InitializeComponent();
        }

        private void config(bool v)
        {
            gvDepartamente.AllowUserToAddRows = !v;
            gvDepartamente.AllowUserToDeleteRows = !v;
            gvDepartamente.ReadOnly = v;
            gvDepartamente.Columns[0].ReadOnly = true;

            btnActualizare.Enabled = v;

            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            departamenteTableAdapter.Fill(dataSet1.Departamente);
            completeazaDepartament();
        }

        private void Departamente_Load(object sender, EventArgs e)
        {
            txtIdDept.Visible = false;
            insertJurnal();
            // TODO: This line of code loads data into the 'dataSet1.AngajatiPeDepart' table. You can move, or remove it, as needed.
            this.angajatiPeDepartTableAdapter.Fill(this.dataSet1.AngajatiPeDepart);
            // TODO: This line of code loads data into the 'dataSet1.JurnalAngajat' table. You can move, or remove it, as needed.
            refresh();
            config(true);
            gvDepartamente.Columns[IdDepartamentIndex].ReadOnly = true;
            gvDepartamente.Columns[DDepartamentIndex].ReadOnly = true;
            filtrare();

        }

        private void completeazaDepartament()
        {
            String idDepart;
            int IdDepartament;
            DataRow r;
            foreach (DataRowView x in departamenteBindingSource)
            {
                idDepart = x["IdDepartament"].ToString();
                IdDepartament = Convert.ToInt32(idDepart);
                r = dataSet1.Tables["Departamente"].Rows.Find(IdDepartament);
                if (r != null)
                {
                    x["Ddepartament"] = r[1].ToString();
                }
                else
                {
                    MessageBox.Show("Nu exista departamentul cu id " + IdDepartament);
                }
            }
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            String idDept;
            int idDepartament;
            DataRow rr;
            foreach (DataRow r in dataSet1.Departamente)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["DDepartament"] == DBNull.Value)
                {
                    MessageBox.Show("Completati campul Departament la linia cu Id " + r["IdDepartament"]);
                    raspuns = false;
                }
                idDept = r["IdDepartament"].ToString();
                idDepartament = Convert.ToInt32(idDept);
                rr = dataSet1.Tables["Departamente"].Rows.Find(idDepartament);
                if (rr != null)
                {
                    r["DDepartament"] = rr[1].ToString();
                    raspuns = true;
                }
                else
                {
                    MessageBox.Show("Selectati departamentul la linia cu Id " + idDepartament);
                    raspuns = false;
                }
            }
            return raspuns;
        }
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                departamenteTableAdapter.Update(dataSet1.Departamente);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Departamentul exista. Introduceti alta denumire pentru departament!");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void gvDepartamente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView crt;
            
            try
            {
                if (gvDepartamente.CurrentCell == null) return;
                if (gvDepartamente.CurrentCell.ColumnIndex == DDepartamentIndex)
                {
                    crt = (DataRowView)departamenteBindingSource.Current;
                    gvDepartamente.CurrentRow.Cells[IdDepartamentIndex].Value = crt["IdDepartament"];
                }
            }
            catch { }
        }

        private void gvDepartamente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gvDepartamente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void gvDepartamente_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A1(e.Row.Cells[0].Value.ToString(), e);
        }

        private void gvDepartamente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                gvDepartamente.CancelEdit();
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }
        private void A1(String id, DataGridViewRowCancelEventArgs e)
        {
            con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "(SELECT 'TAB1' FROM Angajari WHERE IdDepartament = " + id + ") UNION (SELECT 'TAB2' FROM Demisii WHERE  IdDepartament = " + id + ") UNION (SELECT 'TAB3' FROM Transferuri WHERE  IdDepartamentSursa = " + id + " OR IdDepartamentDestinatie=" + id + ")";
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Departamentul are angajati si nu poate fi sters!");
                e.Cancel = true;
                con.Close();
                return;
                } 
                const string mesaj = "Confirmati stergerea";
                const string titlu = "Stergere inregistrare";
                var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.No) e.Cancel = true;
                con.Close();
        }

        private void departamenteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            filtrare();
        }
        private void filtrare()
        {
            try { angajatiPeDepartBindingSource.Filter = "IdDepartament=" + txtIdDept.Text; }
            catch { }
        }
        private void insertJurnal()
        {
            con.ConnectionString = angajatiPeDepartTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete * from JurnalAngajat";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                              "SELECT  IdAngajat, 2, Data, IdDepartament " +
                              "FROM Angajari";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                  "SELECT  IdAngajat, 4, Data, IdDepartamentDestinatie " +
                  "FROM Transferuri";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                  "SELECT  IdAngajat, 5, Data, IdDepartamentSursa " +
                  "FROM Transferuri";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
      "SELECT  IdAngajat, 3, Data, IdDepartament " +
      "FROM Demisii";
            cmd.ExecuteNonQuery();
            con.Close();
            // MessageBox.Show(cmd.CommandText);
            this.dataSet1.JurnalAngajat.Clear();
            this.angajatiPeDepartTableAdapter.Fill(this.dataSet1.AngajatiPeDepart);
        }

    }
}
