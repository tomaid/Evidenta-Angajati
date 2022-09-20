using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class SituatieDepartamente : Form
    {
        DateTime date, d1, d2;
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();
        public SituatieDepartamente(DateTimePicker dtpLunaAn)
        {
            this.date = dtpLunaAn.Value;
            InitializeComponent();
        }

        private void SituatieDepartamente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'balDS.Balanta' table. You can move, or remove it, as needed.
            //this.balantaTableAdapter.Fill(this.balDS.Balanta);
            // TODO: This line of code loads data into the 'dataSet1.CalculDepartamente' table. You can move, or remove it, as needed.
            // this.calculDepartamenteTableAdapter.Fill(this.dataSet1.CalculDepartamente);
            txtIdDept.Visible = false;
            //            DateTime date = DateTime.Now;
            
            d1 = new DateTime(date.Year, date.Month, 1);
            d2 = d1.AddMonths(1).AddDays(-1);
            //dtpStart.Value = d1;
            //dtpStop.Value = d2;
            // MessageBox.Show(d1.ToString());
            // MessageBox.Show(d2.ToString());
            lblSitDept.Text = "Situatie departamente pentru luna " + conversieLuna(d1.Month) + " " + Convert.ToString(d1.Year);
            stocInitial(d1);
            intrari(d1, d2);
            iesiri(d1, d2);
            transferin(d1, d2);
            transferdin(d1, d2);
            stocFinal(d1, d2);
            actualizare(d1, d2);
            balantaDepartamente();
            filtrare();
        }
        private void filtrare()
        {
            try { calculDepartamenteBindingSource.Filter = "IdDepartament=" + txtIdDept.Text; }
            catch { }
        }

        private void actualizare(DateTime dtStart, DateTime dtStop)
        {
            this.calculDepartamenteTableAdapter.Fill(this.dataSet1.CalculDepartamente);
/*            this.balDS.EnforceConstraints = false;
            this.balDS.Balanta.Clear();
            this.balDS.Intrari.Clear();
            this.balDS.Iesiri.Clear();
            this.balDS.StocInitial.Clear();*/
           // this.balantaTableAdapter.Fill(this.balDS.Balanta);
            //  this.balantaDepartamenteTableAdapter.Fill(this.dataSet1.BalantaDepartamente);
        }


        private void stocInitial(DateTime dtStart)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE * FROM BalantaDepartamente";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE * FROM CalculDepartamente";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE * FROM ArhivaAngajati";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 0,Data, IdDepartament, IdAngajat, 1 " +
                              "From Angajari WHERE Data < " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "#";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 0,Data, IdDepartamentSursa, IdAngajat, -1 " +
                              "From Transferuri WHERE Data < " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "#";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 0,Data, IdDepartamentDestinatie, IdAngajat, 1 " +
                              "From Transferuri WHERE Data < " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "#";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 0,Data, IdDepartament, IdAngajat, -1 " +
                              "From Demisii WHERE Data < " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "#";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "SELECT  1,now(), IdDepartament, 0,Sum(CalculDepartamente.Valoare) AS Valoare " +
                              "FROM CalculDepartamente GROUP BY CalculDepartamente.IdDepartament";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Insert into ArhivaAngajati(Data, IdDepartament, NumarAngajati) " +
                              "SELECT now(), IdDepartament, Sum(CalculDepartamente.Valoare) AS NumarAngajati " +
                              "FROM CalculDepartamente  WHERE CalculDepartamente.IdOperatie=1 GROUP BY CalculDepartamente.IdDepartament";
            cmd.ExecuteNonQuery();
            //cmd.CommandText = "DELETE * FROM CalculDepartamente WHERE IdOperatie = 0";
            // cmd.ExecuteNonQuery();
            con.Close();
        }
        private void intrari(DateTime dtStart, DateTime dtStop)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 2,Data, IdDepartament, IdAngajat, 1 " +
                              "From Angajari WHERE Data >= " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "# AND Data <= " + "#" + Convert.ToString(dtStop.Month) + "/"
                               + Convert.ToString(dtStop.Day) + "/"
                               + Convert.ToString(dtStop.Year) + "#";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void iesiri(DateTime dtStart, DateTime dtStop)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 3,Data, IdDepartament, IdAngajat, -1 " +
                              "From Demisii WHERE Data >= " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "# AND Data <= " + "#" + Convert.ToString(dtStop.Month) + "/"
                               + Convert.ToString(dtStop.Day) + "/"
                               + Convert.ToString(dtStop.Year) + "#";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void transferin(DateTime dtStart, DateTime dtStop)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 4,Data, IdDepartamentDestinatie, IdAngajat, 1 " +
                              "From Transferuri WHERE Data >= " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "# AND Data <= " + "#" + Convert.ToString(dtStop.Month) + "/"
                               + Convert.ToString(dtStop.Day) + "/"
                               + Convert.ToString(dtStop.Year) + "#";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void transferdin(DateTime dtStart, DateTime dtStop)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 5,Data, IdDepartamentSursa, IdAngajat, -1 " +
                              "From Transferuri WHERE Data >= " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "# AND Data <= " + "#" + Convert.ToString(dtStop.Month) + "/"
                               + Convert.ToString(dtStop.Day) + "/"
                               + Convert.ToString(dtStop.Year) + "#";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void stocFinal(DateTime dtStart, DateTime dtStop)
        {
            con.ConnectionString = this.calculDepartamenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Insert into CalculDepartamente(IdOperatie, Data, IdDepartament, IdAngajat, Valoare) " +
                              "Select 6, now(), IdDepartament, 0, SUM(CalculDepartamente.Valoare) AS Valoare " +
                              "From CalculDepartamente WHERE IdOperatie > 0 AND Data >= " + "#" + Convert.ToString(dtStart.Month) + "/"
                               + Convert.ToString(dtStart.Day) + "/"
                               + Convert.ToString(dtStart.Year) + "# AND Data <= " + "#" + Convert.ToString(dtStop.Month) + "/"
                               + Convert.ToString(dtStop.Day) + "/"
                               + Convert.ToString(dtStop.Year) + "# GROUP BY IdDepartament";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void balantaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            filtrare();
        }
 

        public void balantaDepartamente()
        {
            con.ConnectionString = this.balantaTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE * FROM BalantaDepartamente";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO BalantaDepartamente ( IdDepartament, AngajatiFinal )" +
                            " SELECT IdDepartament, Valoare FROM CalculDepartamente Where IdOperatie=6";
            cmd.ExecuteNonQuery();
            con.Close();
            balantaTableAdapter.Fill(balDS.Balanta);
            BalDSTableAdapters.StocInitialTableAdapter ta2 = new BalDSTableAdapters.StocInitialTableAdapter();
            ta2.Fill(balDS.StocInitial);
            try {
                DataRelation balStocInitial = balDS.Relations.Add(balDS.Balanta.Columns["IdDepartament"], balDS.StocInitial.Columns["IdDepartament"]);
          
                foreach (DataRow rb in balDS.Balanta)
                {
                    foreach (DataRow ri in rb.GetChildRows(balStocInitial))
                    {
                        rb["AngajatiInitial"] = ri["Total"];
                    }
                }
            }
            catch{}
            BalDSTableAdapters.IntrariTableAdapter ta = new BalDSTableAdapters.IntrariTableAdapter();
            ta.Fill(balDS.Intrari);
            try { 
                DataRelation balIntrari = balDS.Relations.Add(balDS.Balanta.Columns["IdDepartament"], balDS.Intrari.Columns["IdDepartament"]);

                foreach (DataRow rb in balDS.Balanta)
                {
                    foreach (DataRow ri in rb.GetChildRows(balIntrari))
                    {
                        rb["Intrari"] = ri["Total"];
                    }
                }
            } catch { }
            BalDSTableAdapters.IesiriTableAdapter ta1 = new BalDSTableAdapters.IesiriTableAdapter();
            ta1.Fill(balDS.Iesiri);

            try { 
            DataRelation balIesiri = balDS.Relations.Add(balDS.Balanta.Columns["IdDepartament"], balDS.Iesiri.Columns["IdDepartament"]);

            foreach (DataRow rb in balDS.Balanta)
            {
                foreach (DataRow ri in rb.GetChildRows(balIesiri))
                {
                    rb["Iesiri"] = ri["Total"];
                }
            }
            }
            catch { }

        }

        private string conversieLuna(int i)
        {
            switch (i)
            {
                case 1:
                    return "ianuarie";
                case 2:
                    return "februarie";
                case 3:
                    return "martie";
                case 4:
                    return "aprilie";
                case 5:
                    return "mai";
                case 6:
                    return "iunie";
                case 7:
                    return "iulie";
                case 8:
                    return "august";
                case 9:
                    return "septembrie";
                case 10:
                    return "octombrie";
                case 11:
                    return "noiembrie";
                case 12:
                    return "decembrie";
                default:
                    return "";
            }
        }
    }
}
