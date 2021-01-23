package com.company;

import java.util.Calendar;

abstract class Personne {
    private String nom;
    private String prenom;
    private Calendar dateN;
    private String adresse;
    private String ville;

    //
    public Personne(String nom, String prenom, String adresse, String ville, Calendar dateNaissance) {
        this.nom = nom;
        this.prenom = prenom;
        this.dateN = dateNaissance;
        this.adresse = adresse;
        this.ville = ville;
    }

    //
    @Override
    public String toString() {
        return String.format("Nom : %s, Prenom : %s, Date de naissance : %s, Adresse : %s, Ville : %s", this.nom, this.prenom, dateN.getTime().toString(), this.adresse, this.ville);
    }
    //
    public void modifiePersonne(String adresse, String ville){
        this.adresse = adresse;
        this.ville = ville;
    }
    //
    public abstract void ecrirePersonne();
}
