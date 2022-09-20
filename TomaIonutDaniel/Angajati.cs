using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
        }
        private void Angajati_Load(object sender, EventArgs e)
        {
            this.operatiiTableAdapter.Fill(this.dataSet1.Operatii);
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);
            this.angajatiTableAdapter.Fill(this.dataSet1.Angajati);
            A1();

        }
        private void A1()
        {
            this.departamenteTableAdapter.Fill(this.dataSet1.Departamente);
            this.angajatiTableAdapter.Fill(this.dataSet1.Angajati);
            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtId.DataBindings.Add("Text", angajatiBindingSource, "IdAngajat");
            txtId.ReadOnly = true;
        }
        private void A2(){
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM Angajati WHERE IdAngajat =" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Transferuri WHERE IdAngajat =" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Demisii WHERE IdAngajat =" + txtId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Angajari WHERE IdAngajat =" + txtId.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(angajatiBindingSource.Position);
        }

        private void refreshGrid(int p)
        {
            angajatiTableAdapter.Fill(dataSet1.Angajati);
            angajatiBindingSource.Position = p;
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            AdministrareAngajat f = new AdministrareAngajat();
            f.completeazaTitlu("Introducere angajat");
            f.ShowDialog();
            refreshGrid(angajatiBindingSource.Position);
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            AdministrareAngajat f = new AdministrareAngajat();
            f.completeazaTitlu("Modificare angajat");
            f.bs1 = angajatiBindingSource;
            f.ShowDialog();
            refreshGrid(angajatiBindingSource.Position);
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A2();
        }
    }

}
