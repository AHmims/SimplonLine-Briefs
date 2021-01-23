package com.company;

public class ArticleEnSolde extends Article {
    private int reduction;

    public int getReduction() {
        return reduction;
    }
    public void setReduction(int reduction) {
        this.reduction = reduction;
    }

    public ArticleEnSolde(String nom, Double prix, int reduction) {
        super(nom, prix);
        this.reduction = reduction;
    }
    public ArticleEnSolde(Article article, int reduction){
        super(article);
        this.reduction = reduction;
    }
    //
    private Double calculateReduction(){
        return (this.getPrix() - (this.getPrix() * ((float) this.reduction / 100)));
    }
    //
    @Override
    public String afficher(){
        return String.format("%s, Pourcentage de remise : %d, prix apres la reduction : %f", super.afficher(), this.reduction, this.calculateReduction());
    }
}
