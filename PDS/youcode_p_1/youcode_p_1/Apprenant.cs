using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace youcode_p_1
{
    public class Apprenant
    {
        private string _nom;
        private string _prenom;
        private DateTime _dn;
        private int _tel;
        private string _mail;
        private string _pays;
        private string _ville;
        private string _sp;
        public Apprenant(string nom, string prenom, DateTime dateNaissance, int tel, string mail, string pays, string ville, string specialites)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._dn = dateNaissance;
            this._tel = tel;
            this._mail = mail;
            this._pays = pays;
            this._ville = ville;
            this._sp = specialites;
        }
        //get all fields as an array
        public string[] getAll(int pos)
        {
            return new[]
            {
                pos.ToString(), this._nom, this._prenom, this._dn.Date.ToString(), this._tel.ToString(), this._mail, this._pays, this._ville, this._sp
            };
        }
        //
        public ArrayList Validate()
        {
            ArrayList errors = new ArrayList();
            //
            // name validation
            if (!validateValue("name",this._nom))
                errors.Add("Nom non valide");
            //secondName validation
            if (!validateValue("name", this._prenom))
                errors.Add("Prénom non valide");
            //email validation
            if (!validateValue("email", this._mail))
                errors.Add("Adresse email non valide");
            //Phone number validation
            if(this._tel == 0)
                errors.Add("Numéro de téléphone non valide");
            // country / city validation
            string[] payS = {"Maroc", "France"};
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
            // age validation
            int age = DateTime.Now.Year - this._dn.Year;
            if(age < 18 || age >= 30)
                errors.Add("Age doit etre entre 18 et 30ans");
            // specialties
            Boolean Sexists = false;
            string[] specialties = {"C#", "JEE", "Back-end & Front-end"};
            foreach (var specialty in specialties)
            {
                if (specialty == this._sp)
                {
                    Sexists = true;
                    break;
                }
            }
            if(!Sexists)
                errors.Add("Spécialité non valide");
            //
            return errors;
        }
        //
        //function to validate input via regex, returns true if valide, else false
        private Boolean validateValue(string type, string input)
        {
            Boolean res = false;
            if (input.Length > 0)
            {
                string pattern = "";
                if (type == "name")
                    pattern = @"^[A-Za-z]{2,30}$";
                else if (type == "email")
                    pattern = @"^[A-Za-z0-9-_.]{2,30}\@[A-Za-z0-9]{2,20}\.[A-Za-z]{2,3}$";
                //
                res = Regex.Match(input, pattern).Success;
            }
            return res;
        }
    }
}
