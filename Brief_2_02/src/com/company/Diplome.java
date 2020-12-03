package com.company;

public class Diplome {
    private String titre;
    private String mention;
    private int anobtenu;

    public String getTitre() {
        return titre;
    }

    public void setTitre(String titre) {
        this.titre = titre;
    }

    public String getMention() {
        return mention;
    }

    public void setMention(String mention) {
        this.mention = mention;
    }

    public int getAnobtenu() {
        return anobtenu;
    }

    public void setAnobtenu(int anobtenu) {
        this.anobtenu = anobtenu;
    }
    //
    public Diplome(){}
    public Diplome(String titre, String mention, int anobtenu){
        this.titre = titre;
        this.mention = mention;
        this.anobtenu = anobtenu;
    }
}
