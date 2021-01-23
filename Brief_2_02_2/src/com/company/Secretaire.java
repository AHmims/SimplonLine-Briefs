package com.company;

import java.util.Calendar;

public class Secretaire extends Personne {
    private String numeroBureau;
    static private int compteur = 0;
    //
    public static int getCompteur() {
        return compteur;
    }
    //
    public Secretaire(String nom, String prenom, String adresse, String ville, Calendar dateNaissance, String numeroBureau) {
        super(nom, prenom, adresse, ville, dateNaissance);
        this.numeroBureau = numeroBureau;
        compteur += 1;
    }
    //
    public void ecrirePersonne(){
        System.out.println(super.toString());
    }
    //
    @Override
    public String toString(){
        return String.format("%s , Numero de bureau : %s", super.toString(), this.numeroBureau);
    }
}
