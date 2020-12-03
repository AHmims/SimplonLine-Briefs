package com.company;

public class Chien {
    private String nom;
    public Chien(String nom){
        this.nom = nom;
    }
    //
    public void aboyer(String sens){
        System.out.println(sens);
    }
    //
    public void manger(String qlqc){
        System.out.println(qlqc);
    }
}
