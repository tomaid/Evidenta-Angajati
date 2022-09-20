using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaIonutDaniel
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnAdminDepartamente_Click(object sender, EventArgs e)
        {
            Departamente fd = new Departamente();
            fd.ShowDialog();
        }

        private void btnAdmAngajati_Click(object sender, EventArgs e)
        {
            Angajati fa = new Angajati();
            fa.ShowDialog();
        }

        private void btnSituatieDepartamente_Click(object sender, EventArgs e)
        {
            SituatieDepartamente sd = new SituatieDepartamente(dtpLunaAn);
            sd.ShowDialog();

        }

        private void btnDemisii_Click(object sender, EventArgs e)
        {
            RaportDemisii rd = new RaportDemisii();
            rd.ShowDialog();
        }

        private void btnAngajari_Click(object sender, EventArgs e)
        {
            RaportAngajari ra = new RaportAngajari();
            ra.ShowDialog();

        }
    }
}
