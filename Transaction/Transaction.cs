using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionNS
{
    public class Transaction
    {
        private string dataPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..", "Data"));
        private CultureInfo culture = new CultureInfo("en-CA");
        private const decimal tax = (decimal)0.15;

        #region Declaration des Tableaux

        private string[] tLivreurs = new string[20];
        private string[] tVoitures = new string[20];
        private decimal[] prix = new decimal[20];

        private string _Voiture;
        private string _Livreur;
        private decimal _Prix;

        private string _Courriel;
        private string _Nom;
        private DateTime _Date;
        private decimal _Total;

        #endregion

        public Transaction()
        {
            InitLivreurs();
            InitVoituresPrix();
        }

        #region Initialisation des Tableaux
        private void InitLivreurs()
        {
            try
            {
                string path = Path.Combine(dataPath, "Livreurs.data");

                using (StreamReader sr = new StreamReader(path))
                {
                    string ligne = sr.ReadLine();
                    int length = int.Parse(ligne);

                    Array.Resize(ref tLivreurs, length);

                    for (int i = 0; i < length; i++)
                    {
                        tLivreurs[i] = sr.ReadLine();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void InitVoituresPrix()
        {
            try
            {
                string path = Path.Combine(dataPath, "Voitures.data");

                using (StreamReader sr = new StreamReader(path))
                {
                    string ligne = sr.ReadLine();
                    int length = int.Parse(ligne);

                    Array.Resize(ref tVoitures, length);
                    Array.Resize(ref prix, length);

                    for (int i = 0; i < length; i++)
                    {
                        string voitureArr = sr.ReadLine();
                        string[] voiture = voitureArr.Split(';');

                        tVoitures[i] = voiture[0];
                        prix[i] = decimal.Parse(voiture[1], culture);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region Propriétés

        public string Nom
        {
            get { return _Nom; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                        _Nom = value;
                    else
                        throw new ArgumentException("Le nom est obligatoire");
                }
                else
                    throw new ArgumentNullException("Le nom est obligatoire");
            }
        }
        public string Courriel
        {
            get { return _Courriel; }
            set
            {
                if (value != null)
                {
                    value = value.Trim();

                    if (value != string.Empty)
                        _Courriel = value;
                    else
                        throw new ArgumentException("Le courriel est obligatoire");
                }
                else
                    throw new ArgumentNullException("Le courriel est obligatoire");
            }
        }
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                if (DateTime.Now.AddDays(-10) <= value && value <= DateTime.Now.AddDays(10))
                {
                    _Date = value;
                }
                else
                    throw new ArgumentOutOfRangeException("La date doit se situer dans les 10 jours precedant ou suivant de la date courante");
           
            }
        }
        public string Livreur
        {
            get
            {
                return _Livreur;
            }
            set
            {
                if (value == null)
                    throw new Exception("Le livreur est obligatoire");

                value = value.Trim();

                if (Array.IndexOf(tLivreurs, value) == -1)
                    throw new Exception("Le livreur n'existe pas");

                _Livreur = value;
            }
        }

        public string Voiture
        {
            get
            {
                return _Voiture;
            }
            set
            {
                if (value == null)
                    throw new Exception("La voiture est obligatoire");

                value = value.Trim();

                if (Array.IndexOf(tVoitures, value) == -1)
                    throw new Exception("La voiture n'existe pas");

                _Voiture = value;
            }
        }

        public decimal Prix
        {
            get
            {
                return _Prix;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Le prix doit être supérieur à 0");
                _Prix = value;
            }
        }

        public decimal PrixTotal
        {
            get
            {
                return _Total;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Le prix total doit être supérieur à 0");
                _Total = value;
            }
        }
        #endregion


        public string[] GetVoitures()
        {
            return tVoitures;
        }

        public string[] GetLivreurs()
        {
            return tLivreurs;
        }

        public decimal GetPrix(int voitureIndex)
        {
            try
            {
                return prix[voitureIndex];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public decimal GetTotal(decimal prix)
        {
            decimal taxes = prix * tax;
            return prix + taxes;
        }

        public void Enregistrer(string nom, string courriel, DateTime date,  string livreurs, string voitures, decimal prix)
        {
            try
            {
                this.Nom = nom;
                this.Courriel = courriel;
                this.Date = date;
                this.Livreur = livreurs; 
                this.Voiture = voitures; 
                this.PrixTotal = prix;

                string path = Path.Combine(dataPath, "Transactions.data");

                using (StreamWriter outputFile = new StreamWriter(path, true, Encoding.UTF8))
                {
                    outputFile.WriteLine(this.Nom + ";" + this.Courriel + ";" + this.Date + ";" + this.Livreur + ";" + this.Voiture + ";" + this.PrixTotal);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Une erreur s'est produite pendant l'enregistrement.", exception);
            }
        }

        public void Imprimer(DateTime date, string voitures, decimal prix)
        {
            Console.WriteLine("Date : " + DateTime.Now);
            Console.WriteLine("Date\t\t\t\tProduit\t\t\t\t\t\tPrix");
            Console.WriteLine("------------------\t--------------------------\t------------");
            Console.WriteLine(date.ToString("MMMM dd, yyyy") + "\t" + voitures + "\t\t\t" + prix);
        }
        
    }
}
