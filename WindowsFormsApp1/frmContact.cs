using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RepertoireService.Model;

namespace WindowsFormsApp1
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }
        
        carnetadresseEntities db = new carnetadresseEntities();
        
        ServiceAdressBook.Service1Client serv = new ServiceAdressBook.Service1Client();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                txtPrenom.Select();


            }
        }

        private void txtPrenom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbbSexe.Select();
            }
        }

        private void cbbSexe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCsp.Select();
            }
        }

        private void txtCsp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtVille.Select();
            }
        }

        private void AffichageHeure_Tick(object sender, EventArgs e)
        {
            lblHeure.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void actualiser()
        {
            dgContact.DataSource = serv.getAllContact();

        }

        private void effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtVille.Text = string.Empty;
            txtCsp.Text = string.Empty;
            cbbSexe.DataSource = null;
            cbbSexe.Items.Clear();
            txtNom.Focus();
            actualiser();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            // lblHeure.Text = DateTime.Now.ToString("H:mm:ss");
            actualiser();
            lblNbreRepertorie.Text = serv.getNumberOfContact();
        }

        private void pQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            contact c = new contact();
            
            c.nom = txtNom.Text;
            c.prenom = txtPrenom.Text;
            c.sexe = cbbSexe.Text;
            c.csp = txtCsp.Text;
            c.ville = txtVille.Text;
            serv.addContact(c);
            MessageBox.Show("Le Contact a été ajouté avec success");
            effacer();

        }

        private void dgContact_SelectionChanged(object sender, EventArgs e)
        {
            //int id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
           
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgContact.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgContact.CurrentRow.Cells[2].Value.ToString();
            txtCsp.Text = dgContact.CurrentRow.Cells[3].Value.ToString();
            cbbSexe.Text = dgContact.CurrentRow.Cells[4].Value.ToString();
            txtVille.Text = dgContact.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
            contact user = serv.getIdMatch(id);
            user.nom = txtNom.Text;
            user.prenom = txtPrenom.Text;
            user.sexe = cbbSexe.Text;
            user.ville = txtVille.Text;
            user.csp = txtCsp.Text;
            serv.editContact(user);
            MessageBox.Show("Contact modifié avec succes");
            effacer();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
          
            serv.supprimerContact(id);
            MessageBox.Show("Suppression effectue avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            effacer();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgContact.DataSource = serv.searchContact(txtNom.Text, txtPrenom.Text);
        }

        private void btnAjoutTel_Click(object sender, EventArgs e)
        {

        }
    }
}
