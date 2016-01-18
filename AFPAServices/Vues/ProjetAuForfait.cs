using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AFPAServices.Dao;
using AFPAServices.Metier;


namespace AFPAServices
{
    public partial class Form1 : Form
    {
        Projet pr;
        Penalite penalite = Penalite.Non;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            if (rbtnNon.Checked)
            {
                penalite = Penalite.Non;
            }

            else if (rbtnOui.Checked)
            {
                penalite = Penalite.Oui;
            }
            //if (cbClient.SelectedIndex != -1)
            //    errorProvider1.SetError(cbClient, "");
            //else
            //    errorProvider1.SetError(cbClient, " le choix s'impose");
            //if (cbResponsable.SelectedIndex != -1)
            //    errorProvider1.SetError(cbResponsable, "");
            //else
            //    errorProvider1.SetError(cbResponsable, " le choix s'impose");
            //if (Projets.Find())

            bool dif = true;
            dif = dateFin.Value > dateDebut.Value;
            if (dif == false)
            {

                errorProvider1.SetError(dateFin, "revenez sur votre date de fin");
                

            }
            else
                errorProvider1.SetError(dateFin, "");
            if (Contrôles())
            {
                
                int codep = new Random().Next(0, 1000);
                ProjetForfait Projet = new ProjetForfait(codep, txtNom.Text, DateTime.Parse(dateDebut.Text), DateTime.Parse(dateFin.Text), (Client)cbClient.SelectedItem, txtContact.Text, txtMail.Text, int.Parse(txtMontant.Text), penalite, (Collaborateur)cbResponsable.SelectedItem);
                MessageBox.Show(Projet.ToString(), "Projet enregistré" );
                Dao.DaoProjet.AddProjet(Projet);
                
            }
 
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void List_Load(object sender, EventArgs e)
        {
            
            clientBindingSource.DataSource = Dao.DaoProjet.GetAllClients();
            collaborateurBindingSource.DataSource = Dao.DaoProjet.GetAllChefs();
            projetForfaitBindingSource.DataSource = Dao.DaoProjet.AddProjet(pr);
            projetForfaitBindingSource.DataSource = Dao.DaoProjet.GetAllprojets();
            cbClient.SelectedIndex = -1;
            cbResponsable.SelectedIndex = -1;
            //Initialise();

        }
        //hzdgj

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtMail.Text, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9]+)+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMail, " adresse mail non valide");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMail, "");
            }
        }

       
        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        public bool Contrôles()
        {
            bool a=true;
            

            if (txtNom.Text == "")
            {
                txtNom.Focus();
                MessageBox.Show("le nom du projet est obligatoire");
                return a = false;
            }
            else if (txtMontant.Text == "")
            {
                txtMontant.Focus();
                MessageBox.Show("vous avez oublié le montant du contrat");
                return a = false;
            }
            else if(cbClient.Text==string.Empty)
            {
                cbClient.Focus();
                MessageBox.Show("il me faut un client pour fonctionner");
                return a = false;
            }
            else if (cbResponsable.Text == string.Empty)
            {
                cbResponsable.Focus();
                MessageBox.Show("Pensez au choix du responsable");
                return a = false;
            }
            else { return a; }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmez-vous la suppression", " Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //Projets.Remove(pr);
                //pr.Remove();
                this.Close();
            }
        }

        private void cbRechercheProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dao.DaoProjet.GetAllprojets();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DaoProjet.UpdProjets(pr);
        }
    }
}
