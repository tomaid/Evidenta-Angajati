using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class AdministrareAngajat : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        String idP, numeP, cnpP, dateP;
        int departamentP;
        bool demisieP = false;
        DateTime dateBefore = DateTime.Now;
        public AdministrareAngajat()
        {
            InitializeComponent();
        }
        private void AdministrareAngajat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Departamente' table. You can move, or remove it, as needed.
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);
            // TODO: This line of code loads data into the 'dataSet1.JurnalAngajat' table. You can move, or remove it, as needed.
            txtId.ReadOnly = true;
            cbDemisionat.Enabled = false;
            A3();

        }
        public void completeazaTitlu(String titlu)
        {
            lblAdministrare.Text = titlu;
        }
        private bool validareCampuriObligatorii(string str)
        {
            if ((txtNume.Text == "") && ((str == "nume") || (str == "all")))
            {
                MessageBox.Show("Completati numele angajatului!");
                txtNume.Focus();
                return false;
            }
            if ((txtCNP.Text == "") && ((str == "CNP") || (str == "all")))
            {
                MessageBox.Show("Completati CNP!");
                txtCNP.Focus();
                return false;
            }
            if ((txtCNP.TextLength < 13) && ((str == "CNP") || (str == "all")))
            {
                MessageBox.Show("Introduceti CNP complet (doar cifre)!");
                txtCNP.Focus();
                return false;
            }
            if (!A5() && ((str == "CNP") || (str == "all")))
            {
                MessageBox.Show("Introduceti doar cifre in campul CNP!");
                txtCNP.Focus();
                return false;
            }
            /* 
            MessageBox.Show(dateTP.Text);
            MessageBox.Show(dateBefore.ToString());
            MessageBox.Show(result.ToString());
            int result = DateTime.Compare(dateTP.Value, dateBefore);
            
            if ((result <= 0) && (str == "all"))
            {
                MessageBox.Show("Data introdusă trebuie sa fie mai mare.");
                dateTP.Focus();
                return false;
            }
            */
            return true;
        }
        private void importDateAngajat()
        {
            cbDemisionat.Enabled = true;
            cbDemisionat.Visible = true;
            DataRowView current = (DataRowView)bs1.Current;
            idP = current["IdAngajat"].ToString();
            numeP = current["DAngajat"].ToString();
            cnpP = current["CNP"].ToString();
            txtNume.Text = numeP;
            txtCNP.Text = cnpP;
            txtId.Text = idP;
            refresh();
            int index = dataGridView1.Rows.Count - 1;
            dateP = dataGridView1.Rows[index].Cells[1].Value.ToString();
            departamentP = (int)dataGridView1.Rows[index].Cells[5].Value;
            dateBefore = Convert.ToDateTime(dataGridView1.Rows[index].Cells[1].Value);
            dateTP.Value = Convert.ToDateTime(dataGridView1.Rows[index].Cells[1].Value);
            if ((int)dataGridView1.Rows[index].Cells[4].Value == 3)
            {
                cbDemisionat.Checked = true;
                demisieP = true;
            }
            cmbDepartament.SelectedValue = dataGridView1.Rows[index].Cells[5].Value;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri, listaValori, listaCampuri1, listaValori1;
            con.ConnectionString = angajatiTableAdapter1.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "DAngajat, CNP";
            listaValori = " '" + txtNume.Text + "', '" + txtCNP.Text + "'";

            cmd.CommandText = "Insert into Angajati(" + listaCampuri + ") SELECT " + listaValori;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT @@IDENTITY";
            int id = (int)cmd.ExecuteScalar();
            listaCampuri1 = "Data, IdAngajat, IdDepartament";
            DateTime d = dateTP.Value;
            listaValori1 = "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#," + id + "," + cmbDepartament.SelectedValue;

            cmd.CommandText = "Insert into Angajari(" + listaCampuri1 + ") SELECT " + listaValori1;
            cmd.ExecuteNonQuery();
            con.Close();
            txtId.Text = id.ToString();
            numeP = txtNume.Text;
            cnpP = txtCNP.Text;
            departamentP= (int)cmbDepartament.SelectedValue;
        }
        private void modifica_inregistrare()
        {
            con.ConnectionString = angajatiTableAdapter1.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            bool x = false;
            if ((txtNume.Text != numeP) || (txtCNP.Text != cnpP))
            {
                string listaSet = "DAngajat = '" + txtNume.Text + "', CNP = '" + txtCNP.Text + "'";
                cmd.CommandText = "Update Angajati Set " + listaSet + " Where IdAngajat=" + txtId.Text;
                cmd.ExecuteNonQuery();
                x = true;

            }
            int departamentID = (int)cmbDepartament.SelectedValue;
            if (cbDemisionat.Checked && !demisieP)
            {
                string listaCampuri, listaValori;
                listaCampuri = "Data, IdAngajat, IdDepartament";
                DateTime d = dateTP.Value;
                listaValori = "#" + Convert.ToString(d.Month) + "/"
                                   + Convert.ToString(d.Day) + "/"
                                   + Convert.ToString(d.Year) + "#," + txtId.Text + "," + departamentP;

                cmd.CommandText = "Insert into Demisii(" + listaCampuri + ") SELECT " + listaValori;
                cmd.ExecuteNonQuery();
                demisieP = true;
                departamentP = (int)cmbDepartament.SelectedValue;
            }
            else if (!cbDemisionat.Checked && demisieP)
            {
                string listaCampuri, listaValori;
                listaCampuri = "Data, IdAngajat, IdDepartament";
                DateTime d = dateTP.Value;
                listaValori = "#" + Convert.ToString(d.Month) + "/"
                                   + Convert.ToString(d.Day) + "/"
                                   + Convert.ToString(d.Year) + "#," + txtId.Text + "," + cmbDepartament.SelectedValue;

                cmd.CommandText = "Insert into Angajari(" + listaCampuri + ") SELECT " + listaValori;
                cmd.ExecuteNonQuery();
                demisieP = false;
                departamentP = (int)cmbDepartament.SelectedValue;
            }
            else if (departamentP != departamentID)
            {
                string listaCampuri, listaValori;
                listaCampuri = "Data, IdAngajat, IdDepartamentSursa, IdDepartamentDestinatie";
                DateTime d = dateTP.Value;
                listaValori = "#" + Convert.ToString(d.Month) + "/"
                                   + Convert.ToString(d.Day) + "/"
                                   + Convert.ToString(d.Year) + "#," + txtId.Text + "," + departamentP + "," + cmbDepartament.SelectedValue;

                cmd.CommandText = "Insert into Transferuri(" + listaCampuri + ") SELECT " + listaValori;
                cmd.ExecuteNonQuery();
                departamentP = (int)cmbDepartament.SelectedValue;
            }


            con.Close();
        }
        private void refresh()
        {
            con.ConnectionString = jurnalAngajatTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete * from JurnalAngajat";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                              "SELECT  IdAngajat, 2, Data, IdDepartament " +
                              "FROM Angajari WHERE IdAngajat=" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                  "SELECT  IdAngajat, 4, Data, IdDepartamentDestinatie " +
                  "FROM Transferuri WHERE IdAngajat=" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
                  "SELECT  IdAngajat, 5, Data, IdDepartamentSursa " +
                  "FROM Transferuri WHERE IdAngajat=" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO JurnalAngajat ( IdAngajat, IdOperatie,Data, IdDepartament ) " +
      "SELECT  IdAngajat, 3, Data, IdDepartament " +
      "FROM Demisii WHERE IdAngajat=" + txtId.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            // MessageBox.Show(cmd.CommandText);
            this.dataSet1.JurnalAngajat.Clear();
            this.jurnalAngajatTableAdapter.Fill(this.dataSet1.JurnalAngajat);
        }
        private void A1()
        {
            if (!validareCampuriObligatorii("CNP")) return;
            con.ConnectionString = departamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT 1 FROM Angajati WHERE CNP = '" + txtCNP.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                con.Close();
                MessageBox.Show("Angajatul exista!");
                txtCNP.Focus();
                return;
            }
            con.Close();
        }
        private void A2()
        {
            if (lblAdministrare.Text == "Introducere angajat")
            {
                if (!validareCampuriObligatorii("all")) return;
                adauga_inregistrare();
                refresh();
                MessageBox.Show("Angajatul a fost introdus cu succes!");
                lblAdministrare.Text = "Modificare angajat";
                cbDemisionat.Enabled = true;
                cbDemisionat.Visible = true;
            }
            else if (lblAdministrare.Text == "Modificare angajat")
            {
                if (!validareCampuriObligatorii("all")) return;
                modifica_inregistrare();
                refresh();
                MessageBox.Show("Angajatul a fost modificat cu succes!");
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata");
            }
        }

        private void A3()
        {
            if (lblAdministrare.Text == "Modificare angajat")
            {
                cbDemisionat.Enabled = true;
                cbDemisionat.Visible = true;
                importDateAngajat();
            }
            if (lblAdministrare.Text == "Introducere angajat")
            {
                dataSet1.JurnalAngajat.Clear();
                cbDemisionat.Enabled = false;
                cbDemisionat.Visible = false;
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            AdministrareAngajat.ActiveForm.Close();
        }

        private void txtNume_Leave(object sender, EventArgs e)
        {
            if (!validareCampuriObligatorii("nume")) return;
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A1();
        }
        public bool doarCifre(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            foreach (char character in text)
            {
                if (character < '0' || character > '9')
                    return false;
            }

            return true;
        }
        private bool A5()
        {
            decimal p;

            if (txtCNP.Text == "") return false;
            try
            {
                p = Convert.ToDecimal(txtCNP.Text);
            }
            catch
            {

                return false;
            }
            return true;
        }

    }
}
