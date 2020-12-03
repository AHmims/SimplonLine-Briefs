package com.company;

import java.util.Scanner;

public class Account extends Client {
    private String afficherInfosCompte;

    public Account(String nom, String adresse, Double solde, String afficherInfosCompte) {
        super(nom, adresse, solde);
        this.afficherInfosCompte = afficherInfosCompte;
    }

    //
    public void afficher() {
        switch (this.afficherInfosCompte) {
            case "out.print":
                System.out.print(String.format("%s habite à (%s) - infos solde %f DH\n", this.getNom(), this.getAdresse(), this.getSolde()));
                break;
            case "out.println":
                System.out.println(String.format("%s habite à (%s) - infos solde %f DH", this.getNom(), this.getAdresse(), this.getSolde()));
                break;
            case "out.printf":
                System.out.printf("%s habite à (%s) - infos solde %f DH\n", this.getNom(), this.getAdresse(), this.getSolde());
                break;
            default:
                System.out.println(String.format("%s habite à (%s) - infos solde %f DH", this.getNom(), this.getAdresse(), this.getSolde()));
        }
    }
    //
    public void afficherInfosSolde() {
        System.out.printf("Solde : %f\n", this.getSolde());
    }
    //
    public Double calculerInterer(Double tauxInteret) {
        Double nSolde = this.getSolde() - (this.getSolde() * (tauxInteret / 100));
        System.out.printf("Solde initiale : %f\nTaux d'interet : %f\nNouveau Solde : %f\n", this.getSolde(), tauxInteret, nSolde);
        return nSolde;
    }
    //
    public Boolean retirer(Double m){
        if(m >= 0){
            if(m <= this.getSolde()) {
                this.setSolde(this.getSolde() - m);
                this.afficherInfosSolde();
                return true;
            }
            else
                System.out.println("Erreur ! Montant supérieur à votre solde");
        }else System.out.println("Erreur ! Montant ne peut pas être négatif");
        return false;
    }
}
