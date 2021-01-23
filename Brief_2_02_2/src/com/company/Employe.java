package com.company;

public class Employe {
    private String nom;
    private String prenom;
    private String adress;
    private int anneeNaissance;
    private int anneeEncours;

    //
    public Employe(String nom, String prenom, String adress, int anneeNaissance, int anneeEncours) {
        this.nom = nom;
        this.prenom = prenom;
        this.adress = adress;
        this.anneeNaissance = anneeNaissance;
        this.anneeEncours = anneeEncours;
    }
    public Employe(Employe employe){
        this.nom = employe.nom;
        this.prenom = employe.prenom;
        this.adress = employe.adress;
        this.anneeNaissance = employe.anneeNaissance;
        this.anneeEncours = employe.anneeEncours;
    }

    //
    public int calculerAge() {
        /* Calendar cld = Calendar.getInstance();
        cld.setTime(new Date());
        return cld.get(Calendar.YEAR) - this.anneeNaissance; */
        return this.anneeEncours - this.anneeNaissance;
    }

    //
    public String afficherInfosClient() {
        return String.format("%s %s, né le %d habitant à %s\n", this.nom, this.prenom, this.anneeNaissance, this.adress);
    }
}
