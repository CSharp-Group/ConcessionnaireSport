/*
 * Autheurs: Ava, Jean-Michel, Marie-Louise, Annoir, Adolphe
 * Date: 2024-12-03
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionNS;


namespace ConcessionnaireSport
{
    public partial class ConssesionnaireSport : Form
    {
        private string dataPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", "Data"));
        private CultureInfo culture = new CultureInfo("en-CA");

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
            decimal total = oTrans.GetTotal(prix);

            txtPrix.Text = prix.ToString("C", culture);
            txtTotal.Text = total.ToString("C", culture);
        }

        private void txtCourriel_Leave(object sender, EventArgs e)
        {
            if (isValidCourriel(txtCourriel.Text))
            {
                lblErreurCourriel.Visible = false;
            } else
            {
                lblErreurCourriel.Text = "Courriel invalide";
                lblErreurCourriel.Visible = true;
            }
        }

        private void txtCourriel_Validate(object sender, EventArgs e)
        {
            if (isValidCourriel(txtCourriel.Text))
            {
                lblErreurCourriel.Visible = false;
            }
            else
            {
                lblErreurCourriel.Text = "Courriel invalide";
                lblErreurCourriel.Visible = true;
            }
        }

        #region Methodes

        private bool isValidCourriel(string courriel)
        {
            string pattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"; // regexr.com/2rhq7
            return Regex.IsMatch(courriel, pattern, RegexOptions.IgnoreCase);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            maskedTextBox.SelectAll();
        }

        #endregion
    }
}
