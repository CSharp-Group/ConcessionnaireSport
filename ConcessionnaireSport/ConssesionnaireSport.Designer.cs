namespace ConcessionnaireSport
{
    partial class ConssesionnaireSport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.transactionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoClientGroupBox = new System.Windows.Forms.GroupBox();
            this.lblErreurCourriel = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.MaskedTextBox();
            this.txtCourriel = new System.Windows.Forms.MaskedTextBox();
            this.courrielLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.cboVoiture = new System.Windows.Forms.ComboBox();
            this.cboLivreur = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.produitLabel = new System.Windows.Forms.Label();
            this.fournisseurLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.transactionMenuStrip.SuspendLayout();
            this.infoClientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::ConcessionnaireProche.Properties.Resources.superCarsImage;
            this.imagePictureBox.Location = new System.Drawing.Point(26, 39);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(530, 281);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // transactionMenuStrip
            // 
            this.transactionMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.transactionMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.transactionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.transactionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactionMenuStrip.Name = "transactionMenuStrip";
            this.transactionMenuStrip.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.transactionMenuStrip.Size = new System.Drawing.Size(579, 31);
            this.transactionMenuStrip.TabIndex = 1;
            this.transactionMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::ConcessionnaireProche.Properties.Resources.saveHS;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.Enregistrer);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Image = global::ConcessionnaireProche.Properties.Resources.PrintHS;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.Imprimer);
            // 
            // infoClientGroupBox
            // 
            this.infoClientGroupBox.Controls.Add(this.lblErreurCourriel);
            this.infoClientGroupBox.Controls.Add(this.txtNom);
            this.infoClientGroupBox.Controls.Add(this.txtCourriel);
            this.infoClientGroupBox.Controls.Add(this.courrielLabel);
            this.infoClientGroupBox.Controls.Add(this.nomLabel);
            this.infoClientGroupBox.Location = new System.Drawing.Point(26, 326);
            this.infoClientGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoClientGroupBox.Name = "infoClientGroupBox";
            this.infoClientGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoClientGroupBox.Size = new System.Drawing.Size(530, 159);
            this.infoClientGroupBox.TabIndex = 3;
            this.infoClientGroupBox.TabStop = false;
            this.infoClientGroupBox.Text = "Information du client";
            // 
            // lblErreurCourriel
            // 
            this.lblErreurCourriel.AutoSize = true;
            this.lblErreurCourriel.ForeColor = System.Drawing.Color.Red;
            this.lblErreurCourriel.Location = new System.Drawing.Point(176, 129);
            this.lblErreurCourriel.Name = "lblErreurCourriel";
            this.lblErreurCourriel.Size = new System.Drawing.Size(57, 20);
            this.lblErreurCourriel.TabIndex = 3;
            this.lblErreurCourriel.Text = "Erreur:";
            this.lblErreurCourriel.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(179, 46);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(301, 26);
            this.txtNom.TabIndex = 1;
            this.txtNom.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(179, 98);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(301, 26);
            this.txtCourriel.TabIndex = 2;
            this.txtCourriel.Enter += new System.EventHandler(this.txt_Enter);
            this.txtCourriel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCourriel_Validate);
            this.txtCourriel.Leave += new System.EventHandler(this.txtCourriel_Validate);
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.Location = new System.Drawing.Point(45, 98);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(67, 20);
            this.courrielLabel.TabIndex = 0;
            this.courrielLabel.Text = "Courriel:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(45, 46);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(46, 20);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.dateTimePicker1);
            this.transactionGroupBox.Controls.Add(this.cboVoiture);
            this.transactionGroupBox.Controls.Add(this.cboLivreur);
            this.transactionGroupBox.Controls.Add(this.txtTotal);
            this.transactionGroupBox.Controls.Add(this.txtPrix);
            this.transactionGroupBox.Controls.Add(this.lblTotal);
            this.transactionGroupBox.Controls.Add(this.lblPrix);
            this.transactionGroupBox.Controls.Add(this.produitLabel);
            this.transactionGroupBox.Controls.Add(this.fournisseurLabel);
            this.transactionGroupBox.Controls.Add(this.dateLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(26, 506);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionGroupBox.Size = new System.Drawing.Size(530, 312);
            this.transactionGroupBox.TabIndex = 4;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // cboVoiture
            // 
            this.cboVoiture.FormattingEnabled = true;
            this.cboVoiture.Location = new System.Drawing.Point(179, 151);
            this.cboVoiture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVoiture.Name = "cboVoiture";
            this.cboVoiture.Size = new System.Drawing.Size(301, 28);
            this.cboVoiture.TabIndex = 5;
            this.cboVoiture.SelectedIndexChanged += new System.EventHandler(this.cboVoiture_SelectedIndexChanged);
            // 
            // cboLivreur
            // 
            this.cboLivreur.FormattingEnabled = true;
            this.cboLivreur.Location = new System.Drawing.Point(179, 98);
            this.cboLivreur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLivreur.Name = "cboLivreur";
            this.cboLivreur.Size = new System.Drawing.Size(301, 28);
            this.cboLivreur.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Location = new System.Drawing.Point(327, 261);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(154, 31);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPrix.Location = new System.Drawing.Point(327, 206);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(154, 31);
            this.txtPrix.TabIndex = 0;
            this.txtPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(45, 211);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(42, 20);
            this.lblPrix.TabIndex = 0;
            this.lblPrix.Text = "Prix: ";
            // 
            // produitLabel
            // 
            this.produitLabel.AutoSize = true;
            this.produitLabel.Location = new System.Drawing.Point(45, 155);
            this.produitLabel.Name = "produitLabel";
            this.produitLabel.Size = new System.Drawing.Size(64, 20);
            this.produitLabel.TabIndex = 0;
            this.produitLabel.Text = "Voiture:";
            // 
            // fournisseurLabel
            // 
            this.fournisseurLabel.AutoSize = true;
            this.fournisseurLabel.Location = new System.Drawing.Point(45, 101);
            this.fournisseurLabel.Name = "fournisseurLabel";
            this.fournisseurLabel.Size = new System.Drawing.Size(60, 20);
            this.fournisseurLabel.TabIndex = 0;
            this.fournisseurLabel.Text = "Livreur:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(45, 46);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // ConssesionnaireSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 831);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.infoClientGroupBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.transactionMenuStrip);
            this.MainMenuStrip = this.transactionMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConssesionnaireSport";
            this.Text = "Concessionnaire Voiture Sport";
            this.Load += new System.EventHandler(this.ConssesionnaireSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.transactionMenuStrip.ResumeLayout(false);
            this.transactionMenuStrip.PerformLayout();
            this.infoClientGroupBox.ResumeLayout(false);
            this.infoClientGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.MenuStrip transactionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.GroupBox infoClientGroupBox;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Label courrielLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label produitLabel;
        private System.Windows.Forms.Label fournisseurLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.ComboBox cboVoiture;
        private System.Windows.Forms.ComboBox cboLivreur;
        private System.Windows.Forms.MaskedTextBox txtNom;
        private System.Windows.Forms.MaskedTextBox txtCourriel;
        private System.Windows.Forms.Label lblErreurCourriel;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

