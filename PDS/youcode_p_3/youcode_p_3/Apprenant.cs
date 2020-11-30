using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace youcode_p_3
{
    public class Apprenant
    {
        SqlConnection cnx = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=youcode_p_2;Trusted_Connection=True;");
        //
        private int _id;
        public int id
        {
            get => this._id;
            set => this._id = value;
        }
        private string _nom;
        private string _prenom;
        private DateTime _dn;
        private int _tel;
        private string _mail;
        private string _adresse;
        private string _pays;
        private string _ville;
        private string _sp;
        public Apprenant(string nom, string prenom, DateTime dateNaissance, int tel, string adresse, string mail, string pays, string ville, string specialites, int id = -1)
        {
            this._id = id;
            this._nom = nom;
            this._prenom = prenom;
            this._dn = dateNaissance;
            this._tel = tel;
            this._mail = mail;
            this._adresse = adresse;
            this._pays = pays;
            this._ville = ville;
            this._sp = specialites;
        }
        //retourner les données de l'apprenant en même temps que sa position sous forme de tableau
        public string[] getAll(int pos)
        {
            return new[]
            {
                pos.ToString(), this._nom, this._prenom, this._dn.ToString("d"), $"0{this._tel}", this._adresse, this._mail, this._pays, this._ville, this._sp
            };
        }
        //
        public ArrayList Validate()
        {
            //déclarer une liste de tableaux qui contiendra la description des erreurs trouvées lors de la validation des champs
            ArrayList errors = new ArrayList();
            //
            // valider le nom
            if (!validateValue("name", this._nom))
                errors.Add("Nom non valide");
            //valider le prenom
            if (!validateValue("name", this._prenom))
                errors.Add("Prénom non valide");
            //valider le email
            if (!validateValue("email", this._mail))
                errors.Add("Adresse email non valide");
            //valider le numéro de téléphone
            if (this._tel == 0)
                errors.Add("Numéro de téléphone non valide");
            //
            //assurer que la ville/pays saisi est valide
            string[] payS = { "Maroc", "France" };
            string[][] villes = new string[][]
            {
                new string[] { "Safi", "Casablanca", "Agadir" },
                new string[] { "Paris", "Lorient" }
            };
            Boolean Pexists = false, Vexists = false;
            for (int i = 0; i < payS.Length; i++)
            {
                if (payS[i].ToLower() == this._pays.ToLower())
                {
                    Pexists = true;
                    for (int j = 0; j < villes[i].Length; j++)
                    {
                        if (villes[i][j].ToLower() == this._ville.ToLower())
                        {
                            Vexists = true;
                            break;
                        }
                    }
                }
            }

            if (!Pexists)
            {
                errors.Add("Pays non valide");
                errors.Add("Ville non valide");
            }
            else
            {
                if (!Vexists)
                    errors.Add("Ville non valide");
            }
            //
            // assurer que l'âge est entre 18 et 30 ans
            int age = DateTime.Now.Year - this._dn.Year;
            if (age < 18 || age >= 30)
                errors.Add("Age doit etre entre 18 et 30ans");
            //
            // assurer que la spécialité entée est valide
            Boolean Sexists = false;
            string[] specialties = { "C#", "JEE", "Back-end & Front-end" };
            foreach (var specialty in specialties)
            {
                if (specialty == this._sp)
                {
                    Sexists = true;
                    break;
                }
            }
            if (!Sexists)
                errors.Add("Spécialité non valide");
            //
            return errors;
        }
        //add to DB
        public Boolean save()
        {
            try
            {
                cnx.Open();
                //
                SqlCommand scm = new SqlCommand("INSERT INTO apprenant(nom, prenom, dateNaissance, numTel, adresseMail, adresse, pays, ville, specialites) VALUES (@nom, @prenom, @dateN, @numT, @adrsM, @adrs, @pays, @ville, @spec)", cnx);
                scm.Parameters.AddWithValue("@nom", this._nom);
                scm.Parameters.AddWithValue("@prenom", this._prenom);
                scm.Parameters.AddWithValue("@dateN", this._dn);
                scm.Parameters.AddWithValue("@numT", this._tel);
                scm.Parameters.AddWithValue("@adrsM", this._mail);
                scm.Parameters.AddWithValue("@adrs", this._adresse);
                scm.Parameters.AddWithValue("@pays", this._pays);
                scm.Parameters.AddWithValue("@ville", this._ville);
                scm.Parameters.AddWithValue("@spec", this._sp);
                int insertRes = scm.ExecuteNonQuery();
                //
                cnx.Close();
                //
                if (insertRes > 0)
                    return true;
                else return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        //
        public Boolean update()
        {
            try
            {
                cnx.Open();
                //
                SqlCommand scm = new SqlCommand("UPDATE apprenant SET nom = @nom, prenom = @prenom, dateNaissance = @dateN, numTel = @numT, adresseMail = @adrsM, adresse = @adrs, pays = @pays, ville = @ville, specialites = @spec WHERE identifiant = @id", cnx);
                scm.Parameters.AddWithValue("@nom", this._nom);
                scm.Parameters.AddWithValue("@prenom", this._prenom);
                scm.Parameters.AddWithValue("@dateN", this._dn);
                scm.Parameters.AddWithValue("@numT", this._tel);
                scm.Parameters.AddWithValue("@adrsM", this._mail);
                scm.Parameters.AddWithValue("@adrs", this._adresse);
                scm.Parameters.AddWithValue("@pays", this._pays);
                scm.Parameters.AddWithValue("@ville", this._ville);
                scm.Parameters.AddWithValue("@spec", this._sp);
                scm.Parameters.AddWithValue("@id", this.id);
                int insertRes = scm.ExecuteNonQuery();
                //
                cnx.Close();
                //
                if (insertRes > 0)
                    return true;
                else return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        //fonction de validation d'une valeur en fonction de sa nature et de retourner true/false
        private Boolean validateValue(string type, string input)
        {
            Boolean res = false;
            //vérifier si le nombre de caractères est supérieur à 0
            if (input.Length > 0)
            {
                string pattern = "";
                //assigner un modèle de regex
                if (type == "name")
                    pattern = @"^[A-Za-z]{2,30}$";
                else if (type == "email")
                    pattern = @"^[A-Za-z0-9-_.]{2,30}\@[A-Za-z0-9]{2,20}\.[A-Za-z]{2,3}$";
                //si l'entrée est valide, la variable res aura la valeur true sinon false
                res = Regex.Match(input, pattern).Success;
            }
            return res;
        }
    }
}