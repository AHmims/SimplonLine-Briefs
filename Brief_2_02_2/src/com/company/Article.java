package com.company;

public class Article {
    private String nom;
    private Double prix;

    public String getNom() {
        return nom;
    }
    public Double getPrix() {
        return prix;
    }

    //
    public Article(String nom, Double prix){
        this.nom = nom;
        this.prix = prix;
    }
    public Article(Article article){
        this.nom = article.getNom();
        this.prix = article.getPrix();
    }
    //
    public String afficher(){
        return String.format("%s, prix : %f", this.nom, this.prix);
    }
}
