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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.produitLabel = new System.Windows.Forms.Label();
            this.fournisseurLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cboLivreur = new System.Windows.Forms.ComboBox();
            this.cboVoiture = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.transactionMenuStrip.SuspendLayout();
            this.infoClientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::ConcessionnaireProche.Properties.Resources.superCarsImage;
            this.imagePictureBox.Location = new System.Drawing.Point(17, 25);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(353, 183);
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
            this.transactionMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.transactionMenuStrip.Size = new System.Drawing.Size(386, 24);
            this.transactionMenuStrip.TabIndex = 1;
            this.transactionMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // infoClientGroupBox
            // 
            this.infoClientGroupBox.Controls.Add(this.txtCourriel);
            this.infoClientGroupBox.Controls.Add(this.txtNom);
            this.infoClientGroupBox.Controls.Add(this.courrielLabel);
            this.infoClientGroupBox.Controls.Add(this.nomLabel);
            this.infoClientGroupBox.Location = new System.Drawing.Point(17, 212);
            this.infoClientGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoClientGroupBox.Name = "infoClientGroupBox";
            this.infoClientGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoClientGroupBox.Size = new System.Drawing.Size(353, 103);
            this.infoClientGroupBox.TabIndex = 3;
            this.infoClientGroupBox.TabStop = false;
            this.infoClientGroupBox.Text = "Information du client";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(119, 61);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(203, 20);
            this.txtCourriel.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(119, 28);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(203, 20);
            this.txtNom.TabIndex = 2;
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.Location = new System.Drawing.Point(30, 63);
            this.courrielLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(45, 13);
            this.courrielLabel.TabIndex = 1;
            this.courrielLabel.Text = "Courriel:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(30, 30);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(32, 13);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.cboVoiture);
            this.transactionGroupBox.Controls.Add(this.cboLivreur);
            this.transactionGroupBox.Controls.Add(this.lblTotal);
            this.transactionGroupBox.Controls.Add(this.lblPrix);
            this.transactionGroupBox.Controls.Add(this.txtDate);
            this.transactionGroupBox.Controls.Add(this.totalLabel);
            this.transactionGroupBox.Controls.Add(this.prixLabel);
            this.transactionGroupBox.Controls.Add(this.produitLabel);
            this.transactionGroupBox.Controls.Add(this.fournisseurLabel);
            this.transactionGroupBox.Controls.Add(this.dateLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(17, 329);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transactionGroupBox.Size = new System.Drawing.Size(353, 203);
            this.transactionGroupBox.TabIndex = 4;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(218, 170);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrix
            // 
            this.lblPrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrix.Location = new System.Drawing.Point(218, 134);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(103, 20);
            this.lblPrix.TabIndex = 9;
            this.lblPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(119, 28);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(203, 20);
            this.txtDate.TabIndex = 4;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(30, 173);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // prixLabel
            // 
            this.prixLabel.AutoSize = true;
            this.prixLabel.Location = new System.Drawing.Point(30, 137);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(30, 13);
            this.prixLabel.TabIndex = 5;
            this.prixLabel.Text = "Prix: ";
            // 
            // produitLabel
            // 
            this.produitLabel.AutoSize = true;
            this.produitLabel.Location = new System.Drawing.Point(30, 101);
            this.produitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.produitLabel.Name = "produitLabel";
            this.produitLabel.Size = new System.Drawing.Size(43, 13);
            this.produitLabel.TabIndex = 4;
            this.produitLabel.Text = "Voiture:";
            // 
            // fournisseurLabel
            // 
            this.fournisseurLabel.AutoSize = true;
            this.fournisseurLabel.Location = new System.Drawing.Point(30, 66);
            this.fournisseurLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fournisseurLabel.Name = "fournisseurLabel";
            this.fournisseurLabel.Size = new System.Drawing.Size(42, 13);
            this.fournisseurLabel.TabIndex = 3;
            this.fournisseurLabel.Text = "Livreur:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(30, 30);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // cboLivreur
            // 
            this.cboLivreur.FormattingEnabled = true;
            this.cboLivreur.Location = new System.Drawing.Point(119, 63);
            this.cboLivreur.Name = "cboLivreur";
            this.cboLivreur.Size = new System.Drawing.Size(202, 21);
            this.cboLivreur.TabIndex = 11;
            // 
            // cboVoiture
            // 
            this.cboVoiture.FormattingEnabled = true;
            this.cboVoiture.Location = new System.Drawing.Point(119, 98);
            this.cboVoiture.Name = "cboVoiture";
            this.cboVoiture.Size = new System.Drawing.Size(202, 21);
            this.cboVoiture.TabIndex = 12;
            // 
            // ConssesionnaireSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 540);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.infoClientGroupBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.transactionMenuStrip);
            this.MainMenuStrip = this.transactionMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConssesionnaireSport";
            this.Text = "Concessionnaire Voiture Sport";
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
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.Label produitLabel;
        private System.Windows.Forms.Label fournisseurLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cboVoiture;
        private System.Windows.Forms.ComboBox cboLivreur;
    }
}

