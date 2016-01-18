namespace AFPAServices
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbProjet = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.lbDateFin = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.lbMailContact = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.gbForfait = new System.Windows.Forms.GroupBox();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.collaborateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbPenalites = new System.Windows.Forms.GroupBox();
            this.rbtnNon = new System.Windows.Forms.RadioButton();
            this.rbtnOui = new System.Windows.Forms.RadioButton();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCreer = new System.Windows.Forms.Button();
            this.lbRechercheProjet = new System.Windows.Forms.Label();
            this.cbRechercheProjet = new System.Windows.Forms.ComboBox();
            this.projetForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.gbForfait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).BeginInit();
            this.gbPenalites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjet
            // 
            this.gbProjet.Controls.Add(this.btnSupprimer);
            this.gbProjet.Controls.Add(this.btnAnnuler);
            this.gbProjet.Controls.Add(this.btnModifier);
            this.gbProjet.Controls.Add(this.dateFin);
            this.gbProjet.Controls.Add(this.dateDebut);
            this.gbProjet.Controls.Add(this.cbClient);
            this.gbProjet.Controls.Add(this.txtMail);
            this.gbProjet.Controls.Add(this.txtContact);
            this.gbProjet.Controls.Add(this.txtNom);
            this.gbProjet.Controls.Add(this.btnValider);
            this.gbProjet.Controls.Add(this.lbDateDebut);
            this.gbProjet.Controls.Add(this.lbDateFin);
            this.gbProjet.Controls.Add(this.lbClient);
            this.gbProjet.Controls.Add(this.lbContact);
            this.gbProjet.Controls.Add(this.lbMailContact);
            this.gbProjet.Controls.Add(this.lbNom);
            this.gbProjet.Location = new System.Drawing.Point(57, 51);
            this.gbProjet.Name = "gbProjet";
            this.gbProjet.Size = new System.Drawing.Size(343, 284);
            this.gbProjet.TabIndex = 0;
            this.gbProjet.TabStop = false;
            this.gbProjet.Text = "Projet";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(252, 133);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(252, 58);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(252, 29);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dateFin
            // 
            this.dateFin.Checked = false;
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(107, 101);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(100, 20);
            this.dateFin.TabIndex = 2;
            this.dateFin.Value = new System.DateTime(2016, 1, 13, 15, 24, 33, 0);
            // 
            // dateDebut
            // 
            this.dateDebut.Checked = false;
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebut.Location = new System.Drawing.Point(107, 65);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(100, 20);
            this.dateDebut.TabIndex = 1;
            this.dateDebut.Value = new System.DateTime(2016, 1, 13, 15, 24, 33, 0);
            // 
            // cbClient
            // 
            this.cbClient.DataSource = this.clientBindingSource;
            this.cbClient.DisplayMember = "RaisonSociale";
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(107, 130);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(100, 21);
            this.cbClient.TabIndex = 3;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(AFPAServices.Metier.Client);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(109, 193);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 5;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(109, 159);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 4;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(107, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(252, 98);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Location = new System.Drawing.Point(21, 71);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(66, 13);
            this.lbDateDebut.TabIndex = 5;
            this.lbDateDebut.Text = "Date debut :";
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Location = new System.Drawing.Point(37, 108);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(50, 13);
            this.lbDateFin.TabIndex = 1;
            this.lbDateFin.Text = "Date fin :";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(45, 133);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(42, 13);
            this.lbClient.TabIndex = 3;
            this.lbClient.Text = "Client : ";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(37, 166);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(50, 13);
            this.lbContact.TabIndex = 2;
            this.lbContact.Text = "Contact :";
            // 
            // lbMailContact
            // 
            this.lbMailContact.AutoSize = true;
            this.lbMailContact.Location = new System.Drawing.Point(15, 196);
            this.lbMailContact.Name = "lbMailContact";
            this.lbMailContact.Size = new System.Drawing.Size(72, 13);
            this.lbMailContact.TabIndex = 1;
            this.lbMailContact.Text = "Mail Conatct :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(23, 34);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(64, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom projet :";
            // 
            // gbForfait
            // 
            this.gbForfait.Controls.Add(this.cbResponsable);
            this.gbForfait.Controls.Add(this.gbPenalites);
            this.gbForfait.Controls.Add(this.txtMontant);
            this.gbForfait.Controls.Add(this.label1);
            this.gbForfait.Controls.Add(this.label6);
            this.gbForfait.Location = new System.Drawing.Point(58, 341);
            this.gbForfait.Name = "gbForfait";
            this.gbForfait.Size = new System.Drawing.Size(343, 165);
            this.gbForfait.TabIndex = 1;
            this.gbForfait.TabStop = false;
            this.gbForfait.Text = "Forfait";
            // 
            // cbResponsable
            // 
            this.cbResponsable.DataSource = this.collaborateurBindingSource;
            this.cbResponsable.DisplayMember = "Nom";
            this.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(108, 63);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(100, 21);
            this.cbResponsable.TabIndex = 1;
            // 
            // collaborateurBindingSource
            // 
            this.collaborateurBindingSource.DataSource = typeof(AFPAServices.Metier.Collaborateur);
            // 
            // gbPenalites
            // 
            this.gbPenalites.Controls.Add(this.rbtnNon);
            this.gbPenalites.Controls.Add(this.rbtnOui);
            this.gbPenalites.Location = new System.Drawing.Point(108, 90);
            this.gbPenalites.Name = "gbPenalites";
            this.gbPenalites.Size = new System.Drawing.Size(200, 43);
            this.gbPenalites.TabIndex = 2;
            this.gbPenalites.TabStop = false;
            this.gbPenalites.Text = "Penalites";
            // 
            // rbtnNon
            // 
            this.rbtnNon.AutoSize = true;
            this.rbtnNon.Checked = true;
            this.rbtnNon.Location = new System.Drawing.Point(29, 20);
            this.rbtnNon.Name = "rbtnNon";
            this.rbtnNon.Size = new System.Drawing.Size(45, 17);
            this.rbtnNon.TabIndex = 0;
            this.rbtnNon.TabStop = true;
            this.rbtnNon.Text = "Non";
            this.rbtnNon.UseVisualStyleBackColor = true;
            // 
            // rbtnOui
            // 
            this.rbtnOui.AutoSize = true;
            this.rbtnOui.Location = new System.Drawing.Point(129, 19);
            this.rbtnOui.Name = "rbtnOui";
            this.rbtnOui.Size = new System.Drawing.Size(41, 17);
            this.rbtnOui.TabIndex = 1;
            this.rbtnOui.Text = "Oui";
            this.rbtnOui.UseVisualStyleBackColor = true;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(107, 34);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 0;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Responsable :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Montant contrat :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(362, 31);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(362, 2);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 11;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // lbRechercheProjet
            // 
            this.lbRechercheProjet.AutoSize = true;
            this.lbRechercheProjet.Location = new System.Drawing.Point(12, 12);
            this.lbRechercheProjet.Name = "lbRechercheProjet";
            this.lbRechercheProjet.Size = new System.Drawing.Size(64, 13);
            this.lbRechercheProjet.TabIndex = 11;
            this.lbRechercheProjet.Text = "Nom projet :";
            // 
            // cbRechercheProjet
            // 
            this.cbRechercheProjet.DataSource = this.projetForfaitBindingSource;
            this.cbRechercheProjet.DisplayMember = "NomProjet";
            this.cbRechercheProjet.FormattingEnabled = true;
            this.cbRechercheProjet.Location = new System.Drawing.Point(75, 9);
            this.cbRechercheProjet.Name = "cbRechercheProjet";
            this.cbRechercheProjet.Size = new System.Drawing.Size(121, 21);
            this.cbRechercheProjet.TabIndex = 12;
            this.cbRechercheProjet.SelectedIndexChanged += new System.EventHandler(this.cbRechercheProjet_SelectedIndexChanged);
            // 
            // projetForfaitBindingSource
            // 
            this.projetForfaitBindingSource.DataSource = typeof(AFPAServices.Metier.ProjetForfait);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 473);
            this.Controls.Add(this.cbRechercheProjet);
            this.Controls.Add(this.lbRechercheProjet);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbForfait);
            this.Controls.Add(this.gbProjet);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.List_Load);
            this.gbProjet.ResumeLayout(false);
            this.gbProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.gbForfait.ResumeLayout(false);
            this.gbForfait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).EndInit();
            this.gbPenalites.ResumeLayout(false);
            this.gbPenalites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProjet;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.Label lbDateFin;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbMailContact;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.GroupBox gbForfait;
        private System.Windows.Forms.GroupBox gbPenalites;
        private System.Windows.Forms.RadioButton rbtnNon;
        private System.Windows.Forms.RadioButton rbtnOui;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource collaborateurBindingSource;
        public System.Windows.Forms.DateTimePicker dateDebut;
        public System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cbRechercheProjet;
        private System.Windows.Forms.BindingSource projetForfaitBindingSource;
        private System.Windows.Forms.Label lbRechercheProjet;
        private System.Windows.Forms.Button btnCreer;
    }
}

