using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionNS;


namespace ConcessionnaireSport
{
    public partial class ConssesionnaireSport : Form
    {
        private string dataPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", "Data"));
        private const decimal tax = (decimal)0.15;

        public ConssesionnaireSport()
        {
            InitializeComponent();
        }

        private void ConssesionnaireSport_Load(object sender, EventArgs e)
        {
            Transaction oTrans = new Transaction();

            cboVoiture.Items.AddRange(oTrans.GetVoitures());
            cboLivreur.Items.AddRange(oTrans.GetLivreurs());
        }

        private void cboVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction oTrans = new Transaction();

            decimal prix = oTrans.GetPrix(cboVoiture.SelectedIndex);
            decimal taxes = prix * tax;
            decimal total = prix + taxes;

            txtPrix.Text = prix.ToString("C");
            txtTotal.Text = total.ToString("C");
        }
    }
}
