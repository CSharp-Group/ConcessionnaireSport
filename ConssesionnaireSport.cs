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

namespace ConcessionnaireSport
{
    public partial class ConssesionnaireSport : Form
    {
        private string dataPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", "Data"));
        public ConssesionnaireSport()
        {
            InitializeComponent();
        }

        private void ConssesionnaireSport_Load(object sender, EventArgs e)
        {
            string dataVoitures = Path.Combine(dataPath, "Voitures.data");
            string dataLivreurs = Path.Combine(dataPath, "Livreurs.data");

            // TODO: Get data de transaction refactor ce code
           
            cboVoiture.Items.AddRange(File.ReadAllLines(dataVoitures));
            cboLivreur.Items.AddRange(File.ReadAllLines(dataLivreurs));
        }
    }
}
