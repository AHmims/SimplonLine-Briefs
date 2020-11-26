using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youcode_p_2
{
    public partial class Form1 : Form
    {
        private SqlConnection cnx = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=youcode_p_2;Trusted_Connection=True;");
        private Boolean executed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //initialiser le formulaire
            initForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // remplir la comboBox des spécialités
            string[] sps = { "C#", "JEE", "Back-end & Front-end" }; //initialiser un tableau qui contient les spécialités
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
            string[] payS = { "Maroc", "France" };
            foreach (string pays in payS)
            {
                cbPays.Items.Add(pays);
            }
            cbPays.SelectedIndex = 0;
            // fill cities comboBox
            string[] villes = { "Safi", "Casablanca", "Agadir" };
            foreach (string ville in villes)
            {
                cbVille.Items.Add(ville);
            }
            cbVille.SelectedIndex = 0;
            //
            //
            cbIds.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpF.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            refreshDBLinks();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ArrayList validateRes = validateApprenant();
            if ((bool) validateRes[0])
                addApprenant((Apprenant) validateRes[1]);
        }
        //
        private ArrayList validateApprenant()
        {
            // faire une vérification du numéro de téléphone pour vérifier s'il est valide
            //un numéro de téléphone est valable s'il ne contient que 10 numéros et que les 2 premiers sont soit 06 soit 07
            int numTel = 0;
            if (Regex.Match(tbTel.Text, @"^(06|07)[0-9]{8}$").Success)
                numTel = int.Parse(tbTel.Text);
            //faire une instance de la classe Apprenant avec les valeurs de la formulaire
            Apprenant apprenant = new Apprenant(tbNom.Text, tbPrenom.Text, dtpDN.Value, numTel, tbAdrs.Text, tbMail.Text, cbPays.Text, cbVille.Text, cbSp.Text);
            //
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
                DialogResult boxRet = MessageBox.Show(retMsg, "Erreur de validation des champs",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //si l'utilisateur clique sur le bouton de réessai, refaire le processus de validation
                if (boxRet == DialogResult.Retry)
                    validateApprenant();
            }
            else
            {
                ArrayList Aret = new ArrayList();
                Aret.Add(true);
                Aret.Add(apprenant);
                return Aret;
            }
            //
            ArrayList Aret2 = new ArrayList();
            Aret2.Add(false);
            return Aret2;
        }
        //
        private void addApprenant(Apprenant apprenant)
        {
            Boolean saveRes = apprenant.save();
            if (saveRes)
            {
                refreshDBLinks();
                MessageBox.Show("Apprenant ajouté avec succès", "Succès", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Erreur lors de la sauvegarde des données", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void initForm()
        {
            //vider les entrées de texte
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbTel.Text = "";
            tbMail.Text = "";
            tbAdrs.Text = "";
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
        //
        private void refreshDBLinks()
        {
            executed = false;
            try
            {
                cnx.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM apprenant", cnx);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //
                dataGridView1.DataSource = dt;
                cbIds.DataSource = dt;
                cbIds.ValueMember = "identifiant";
                cbIds.DisplayMember = "identifiant";
                lbCount.Text = $"Nombre des apprenants : {dt.Rows.Count}";
                //
                cnx.Close();
                //
                cnx.Open();
                sda = new SqlDataAdapter("SELECT specialites FROM apprenant GROUP BY specialites ORDER BY specialites ASC", cnx);
                dt = new DataTable();
                sda.Fill(dt);
                //
                cbSpF.DataSource = dt;
                cbSpF.ValueMember = "specialites";
                cbSpF.DisplayMember = "specialites";
                //
                cnx.Close();
                //
                executed = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        private void cbIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (executed)
            {
                try
                {
                    cnx.Open();
                    //
                    SqlCommand cmd = new SqlCommand("SELECT * FROM apprenant WHERE identifiant = @id", cnx);
                    cmd.Parameters.AddWithValue("@id", cbIds.SelectedValue);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        tbNom.Text = sdr["nom"].ToString();
                        tbPrenom.Text = sdr["prenom"].ToString();
                        dtpDN.Value = DateTime.Parse(sdr["dateNaissance"].ToString());
                        tbTel.Text = $"0{sdr["numTel"]}";
                        tbMail.Text = sdr["adresseMail"].ToString();
                        tbAdrs.Text = sdr["adresse"].ToString();
                        //
                        if (sdr["pays"].ToString().ToLower() == "maroc")
                            cbPays.SelectedIndex = 0;
                        else if(sdr["pays"].ToString().ToLower() == "france")
                            cbPays.SelectedIndex = 1;
                        //
                        cbVille.Text = sdr["ville"].ToString();
                        cbSp.Text = sdr["specialites"].ToString();
                    }

                    sdr.Close();
                    //
                    cnx.Close();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception);
                    throw;
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList validateRes = validateApprenant();
                if ((bool) validateRes[0])
                {
                    Apprenant apprenant;
                    apprenant = (Apprenant) validateRes[1];
                    //
                    apprenant.id = Int32.Parse(cbIds.SelectedValue.ToString());
                    //
                    Boolean updateRes = apprenant.update();
                    if (updateRes)
                    {
                        refreshDBLinks();
                        MessageBox.Show("Apprenant modifié avec succès", "Succès", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification d'apprenant", "Erreur", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                throw;
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Est ce que vous etes sure que vouz voulez supprimer cette apprenant ?",
                    "Confirme votre action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cnx.Open();
                    //
                    SqlCommand cmd = new SqlCommand("DELETE FROM apprenant WHERE identifiant = @id", cnx);
                    cmd.Parameters.AddWithValue("@id", cbIds.SelectedValue);
                    //
                    int dltRes = cmd.ExecuteNonQuery();
                    //
                    cnx.Close();
                    //
                    if (dltRes > 0)
                    {
                        initForm();
                        refreshDBLinks();
                        MessageBox.Show("Apprenant supprimé avec succès", "Succès", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression d'apprenant", "Erreur", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                throw;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlDataAdapter sda =
                    new SqlDataAdapter($"SELECT * FROM apprenant WHERE specialites = '{cbSpF.SelectedValue}'", cnx);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //
                dataGridView1.DataSource = dt;
                //
                cnx.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                throw;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            refreshDBLinks();
        }
    }
}
