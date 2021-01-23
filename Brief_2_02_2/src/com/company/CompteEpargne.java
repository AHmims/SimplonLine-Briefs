package com.company;

public class CompteEpargne extends CompteBancaire {
    private Double interet;
    //
    public CompteEpargne(CompteBancaire compteBancaire, Double interet){
        super(compteBancaire);
        if(compteBancaire.solde <= 200)
            compteBancaire.solde = 200.00;
        this.interet = interet;
    }
    //
    public void calculerInterer() {
        Double nSolde = this.getSolde() - (this.getSolde() * (this.interet / 100));
        System.out.printf("Solde initiale : %f\nTaux d'interet : %f\nNouveau Solde : %f\n", this.getSolde(), this.interet, nSolde);
        //return nSolde;
    }
}
