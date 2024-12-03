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
            this.infoClientGroupBox = new System.Windows.Forms.GroupBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.courrielLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.cboVoiture = new System.Windows.Forms.ComboBox();
            this.cboLivreur = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.produitLabel = new System.Windows.Forms.Label();
            this.fournisseurLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.transactionMenuStrip.SuspendLayout();
            this.infoClientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::ConcessionnaireProche.Properties.Resources.superCarsImage;
            this.imagePictureBox.Location = new System.Drawing.Point(23, 31);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(471, 225);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // transactionMenuStrip
            // 
            this.transactionMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.transactionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.transactionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactionMenuStrip.Name = "transactionMenuStrip";
            this.transactionMenuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.transactionMenuStrip.Size = new System.Drawing.Size(515, 26);
            this.transactionMenuStrip.TabIndex = 1;
            this.transactionMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // infoClientGroupBox
            // 
            this.infoClientGroupBox.Controls.Add(this.txtCourriel);
            this.infoClientGroupBox.Controls.Add(this.txtNom);
            this.infoClientGroupBox.Controls.Add(this.courrielLabel);
            this.infoClientGroupBox.Controls.Add(this.nomLabel);
            this.infoClientGroupBox.Location = new System.Drawing.Point(23, 261);
            this.infoClientGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoClientGroupBox.Name = "infoClientGroupBox";
            this.infoClientGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoClientGroupBox.Size = new System.Drawing.Size(471, 127);
            this.infoClientGroupBox.TabIndex = 3;
            this.infoClientGroupBox.TabStop = false;
            this.infoClientGroupBox.Text = "Information du client";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(159, 75);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(269, 22);
            this.txtCourriel.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(159, 34);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(269, 22);
            this.txtNom.TabIndex = 2;
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.Location = new System.Drawing.Point(40, 78);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(56, 16);
            this.courrielLabel.TabIndex = 1;
            this.courrielLabel.Text = "Courriel:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(40, 37);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(39, 16);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.cboVoiture);
            this.transactionGroupBox.Controls.Add(this.cboLivreur);
            this.transactionGroupBox.Controls.Add(this.txtTotal);
            this.transactionGroupBox.Controls.Add(this.txtPrix);
            this.transactionGroupBox.Controls.Add(this.txtDate);
            this.transactionGroupBox.Controls.Add(this.lblTotal);
            this.transactionGroupBox.Controls.Add(this.lblPrix);
            this.transactionGroupBox.Controls.Add(this.produitLabel);
            this.transactionGroupBox.Controls.Add(this.fournisseurLabel);
            this.transactionGroupBox.Controls.Add(this.dateLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(23, 405);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transactionGroupBox.Size = new System.Drawing.Size(471, 250);
            this.transactionGroupBox.TabIndex = 4;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // cboVoiture
            // 
            this.cboVoiture.FormattingEnabled = true;
            this.cboVoiture.Location = new System.Drawing.Point(159, 121);
            this.cboVoiture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVoiture.Name = "cboVoiture";
            this.cboVoiture.Size = new System.Drawing.Size(268, 24);
            this.cboVoiture.TabIndex = 12;
            this.cboVoiture.SelectedIndexChanged += new System.EventHandler(this.cboVoiture_SelectedIndexChanged);
            // 
            // cboLivreur
            // 
            this.cboLivreur.FormattingEnabled = true;
            this.cboLivreur.Location = new System.Drawing.Point(159, 78);
            this.cboLivreur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLivreur.Name = "cboLivreur";
            this.cboLivreur.Size = new System.Drawing.Size(268, 24);
            this.cboLivreur.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTotal.Location = new System.Drawing.Point(291, 209);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 25);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPrix.Location = new System.Drawing.Point(291, 165);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(137, 25);
            this.txtPrix.TabIndex = 9;
            this.txtPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(159, 34);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(269, 22);
            this.txtDate.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(40, 213);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(40, 169);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(35, 16);
            this.lblPrix.TabIndex = 5;
            this.lblPrix.Text = "Prix: ";
            // 
            // produitLabel
            // 
            this.produitLabel.AutoSize = true;
            this.produitLabel.Location = new System.Drawing.Point(40, 124);
            this.produitLabel.Name = "produitLabel";
            this.produitLabel.Size = new System.Drawing.Size(52, 16);
            this.produitLabel.TabIndex = 4;
            this.produitLabel.Text = "Voiture:";
            // 
            // fournisseurLabel
            // 
            this.fournisseurLabel.AutoSize = true;
            this.fournisseurLabel.Location = new System.Drawing.Point(40, 81);
            this.fournisseurLabel.Name = "fournisseurLabel";
            this.fournisseurLabel.Size = new System.Drawing.Size(50, 16);
            this.fournisseurLabel.TabIndex = 3;
            this.fournisseurLabel.Text = "Livreur:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(40, 37);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 16);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // ConssesionnaireSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 665);
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
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cboVoiture;
        private System.Windows.Forms.ComboBox cboLivreur;
    }
}

