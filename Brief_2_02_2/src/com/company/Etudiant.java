package com.company;

import java.util.Calendar;

public class Etudiant extends Personne {
    private String diplome;
    static private int compteur = 0;
    //
    public static int getCompteur() {
        return compteur;
    }
    //
    public Etudiant(String nom, String prenom, String adresse, String ville, Calendar dateNaissance, String diplome){
        super(nom, prenom, adresse, ville, dateNaissance);
        this.diplome = diplome;
        compteur += 1;
    }
    //
    public void ecrirePersonne(){
        System.out.println(super.toString());
    }
    //
    @Override
    public String toString(){
        return String.format("%s , Etat de diplome : %s", super.toString(), this.diplome);
    }
}
