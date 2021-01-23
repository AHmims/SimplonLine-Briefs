package com.company;

import java.util.Calendar;

public class Enseignant extends Personne{
    private String specialite;
    static private int compteur = 0;
    //
    public static int getCompteur() {
        return compteur;
    }
    //
    public Enseignant(String nom, String prenom, String adresse, String ville, Calendar dateNaissance, String specialite){
        super(nom, prenom, adresse, ville, dateNaissance);
        this.specialite = specialite;
        compteur += 1;
    }
    //
    public void ecrirePersonne(){
        System.out.println(super.toString());
    }
    //
    @Override
    public String toString(){
        return String.format("%s , Spécialité : %s", super.toString(), this.specialite);
    }
}
