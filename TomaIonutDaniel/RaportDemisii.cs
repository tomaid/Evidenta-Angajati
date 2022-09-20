using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class RaportDemisii : Form
    {
        DateTime date, d1, d2;

        public RaportDemisii()
        {
            InitializeComponent();
        }

        private void RaportDemisii_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            this.date = dtpDate.Value;
            d1 = new DateTime(date.Year, date.Month, 1);
            d2 = d1.AddMonths(1).AddDays(-1);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("luna", conversieLuna(d1.Month));
            parameters[1] = new ReportParameter("anul", Convert.ToString(d1.Year));
            reportViewer1.LocalReport.SetParameters(parameters);

            // TODO: This line of code loads data into the 'DataSet1.RaportDemisii' table. You can move, or remove it, as needed.
            this.RaportDemisiiTableAdapter.Fill(this.DataSet1.RaportDemisii, d1, d2);
            this.reportViewer1.RefreshReport();
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
