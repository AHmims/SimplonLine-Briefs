package com.company;

public class CompteBancaire extends Employe {
    protected Long numCompte;
    protected Double solde;

    public Double getSolde() {
        return solde;
    }

    //
    public CompteBancaire(Employe employe, Long numCompte, Double solde) {
        super(employe);
        this.numCompte = numCompte;
        this.solde = solde;
    }

    public CompteBancaire(CompteBancaire compteBancaire) {
        super((Employe) compteBancaire);
        this.numCompte = compteBancaire.numCompte;
        this.solde = compteBancaire.solde;
    }

    //
    public void Ajouter(Double solde) {
        this.solde += solde;
    }

    public void Retirer(Double solde) {
        if(solde <= this.solde)
            this.solde -= solde;
        else
            System.out.println("Le nombre ne peut pas être supérieur au solde");
    }

    public String Afficher() {
        return String.format("%s, Solde : %f", super.afficherInfosClient(), this.solde);
    }
}
