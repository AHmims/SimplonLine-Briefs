using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youcode_p_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //une liste qui contient tous les apprenants ajoutés
        private ArrayList apprenants = new ArrayList();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //initialiser le formulaire
            initForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // remplir la comboBox des spécialités
            string[] sps = {"C#", "JEE", "Back-end & Front-end"}; //initialiser un tableau qui contient les spécialités
            //boucle sur chaque entrée du tableau, et ajouter cette valeur à la combobox
            foreach (string sp in sps)
            {
                cbSp.Items.Add(sp);
            }
            //sélectionnez la première option
            cbSp.SelectedIndex = 0;
            //modifier le style de la combobox pour ne pas permettre la modification
            cbSp.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // remplir la comboBox des pays
            string[] payS = {"Maroc", "France"};
            foreach (string pays in payS)
            {
                cbPays.Items.Add(pays);
            }
            cbPays.SelectedIndex = 0;
            // fill cities comboBox
            string[] villes = {"Safi", "Casablanca", "Agadir"};
            foreach (string ville in villes)
            {
                cbVille.Items.Add(ville);
            }
            cbVille.SelectedIndex = 0;
            //initialiser le listview avec des colonnes
            lvApp.View = View.Details;
            lvApp.Columns.Add("Position", 50, HorizontalAlignment.Left);
            lvApp.Columns.Add("Nom", 40, HorizontalAlignment.Left);
            lvApp.Columns.Add("Prénom", 50, HorizontalAlignment.Left);
            lvApp.Columns.Add("Date de naissance", 110, HorizontalAlignment.Left);
            lvApp.Columns.Add("Téléphone", 65, HorizontalAlignment.Left);
            lvApp.Columns.Add("Adresse email", 80, HorizontalAlignment.Left);
            lvApp.Columns.Add("Pays", 35, HorizontalAlignment.Left);
            lvApp.Columns.Add("Ville", 35, HorizontalAlignment.Left);
            lvApp.Columns.Add("Spécialités", 65, HorizontalAlignment.Left);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // faire une vérification du numéro de téléphone pour vérifier s'il est valide
            //un numéro de téléphone est valable s'il ne contient que 10 numéros et que les 2 premiers sont soit 06 soit 07
            int numTel = 0;
            if (Regex.Match(tbTel.Text, @"^(06|07)[0-9]{8}$").Success)
                numTel = int.Parse(tbTel.Text);
            //faire une instance de la classe Apprenant avec les valeurs de la formulaire
            Apprenant apprenant = new Apprenant(tbNom.Text, tbPrenom.Text, dtpDN.Value, numTel, tbMail.Text, cbPays.Text, cbVille.Text, cbSp.Text);
            //fonction pour vérifier si les valeurs données sont valides
            validateForm(apprenant);
        }
        //
        private void validateForm(Apprenant apprenant)
        {
            //appeler la méthode Classe .Validate() pour vérifier si les données fournies sont valides et renvoyer les résultats 
            ArrayList ret = apprenant.Validate();
            // si ret.Count > 0, cela signifie qu'il y a une ou plusieurs erreurs, donc le formulaire n'est pas valide
            if (ret.Count > 0)
            {
                //variable qui aura le message d'erreur à afficher plus tard
                string retMsg = "";
                int i = 1;
                //la variable ret est un ensemble d'erreurs renvoyées par .Validate()
                //pour chaque erreur, nous concaténons la variable retMsg avec le message d'erreur et le numéro du message
                foreach (var msg in ret)
                {
                    retMsg += $"{i}: {msg}\n";
                    i++;
                }
                //afficher un popup avec les erreurs
                DialogResult boxRet = MessageBox.Show(retMsg, "Erreur de validation des champs", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //si l'utilisateur clique sur le bouton de réessai, refaire le processus de validation
                if (boxRet == DialogResult.Retry)
                    validateForm(apprenant);
            }
            else //si le formulaire y est valide
            {
                //ajouter l'Apprenant à la liste des Apprenants
                apprenants.Add(apprenant);
                //afficher l'apprenant dans la listeView
                ListViewItem lvApprenant = new ListViewItem(apprenant.getAll(apprenants.Count));
                lvApp.Items.Add(lvApprenant);
                //afficher un popup avec un message de succès
                MessageBox.Show("Apprenant ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void initForm()
        {
            //vider les entrées de texte
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbTel.Text = "";
            tbMail.Text = "";
            //sélectionnez la première option
            cbVille.SelectedIndex = 0;
            cbPays.SelectedIndex = 0;
            cbSp.SelectedIndex = 0;
            //date fixée à la date actuelle
            dtpDN.Value = DateTime.Now;
        }

        private void cbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            string[] payS = { "Maroc", "France" };
            string[][] villes = new string[][]
            {
                new string[] { "Safi", "Casablanca", "Agadir" },
                new string[] { "Paris", "Lorient" }
            };
            //boucle sur tous les pays
            for (int i = 0; i < payS.Length; i++)
            {
                //si le pays est égal à la valeur sélectionnée
                if (cbPays.Text == payS[i])
                {
                    //vider la combobox des villes
                    cbVille.Items.Clear();
                    //remplir la combobox avec les villes qui appartiennent au pays sélectionné
                    foreach (string ville in villes[i])
                    {
                        cbVille.Items.Add(ville);
                    }
                    cbVille.SelectedIndex = 0;
                }
            }
        }
    }
}
