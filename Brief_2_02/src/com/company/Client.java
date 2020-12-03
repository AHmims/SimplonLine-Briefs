package com.company;

public class Client {
    protected String nom;
    protected String adresse;
    protected Double solde;
    //
    public String getNom() {
        return nom;
    }
    public void setNom(String nom) {
        this.nom = nom;
    }
    public String getAdresse() {
        return adresse;
    }
    public void setAdresse(String adresse) {
        this.adresse = adresse;
    }
    public Double getSolde() {
        return solde;
    }
    public void setSolde(Double solde) {
        this.solde = solde;
    }
    //
    public Client(String nom, String adresse, Double solde) {
        this.nom = nom;
        this.adresse = adresse;
        this.solde = solde;
    }
}
