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

            cboLivreur.SelectedIndex = 0;
            cboVoiture.SelectedIndex = 0;
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

        private void Enregistrer(object sender, EventArgs e)
        {
            ValidateChildren();
            Transaction oTrans = new Transaction();

            try
            {
                oTrans.Enregistrer(txtNom.Text, txtCourriel.Text, DateTime.Parse(dateTimePicker1.Text),
                    cboLivreur.Text, cboVoiture.Text, Decimal.Parse(txtPrix.Text, System.Globalization.NumberStyles.Currency));
                MessageBox.Show("Transaction enregistrée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Imprimer(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"Date : {DateTime.Now:D}");
                Console.WriteLine();

                string headerFormat = "{0,-20} {1,-20} {2,10}";
                Console.WriteLine(string.Format(headerFormat, "Date", "Produit", "Prix"));
                Console.WriteLine(new string('-', 19) + "  " + new string('-', 25) + "  " + new string('-', 14)); // Ligne de séparation

                decimal prixTotal = 0;

                using (StreamReader sr = new StreamReader(Path.Combine(dataPath, "Transactions.data")))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] transaction = line.Split(';');
                        DateTime date = DateTime.Parse(transaction[2]);
                        string produit = transaction[4];
                        decimal prix = Decimal.Parse(transaction[5], culture);

                        Console.WriteLine(string.Format("{0,-20} {1, -20} {2,20}", date.ToString("MMMM dd, yyyy"), produit, prix.ToString("C", culture)));
                        prixTotal += prix;
                    }
                }

                Console.WriteLine();
                Console.WriteLine(string.Format("{0,-41} {1,20}", "Total de la transaction : ", prixTotal.ToString("C", culture)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
