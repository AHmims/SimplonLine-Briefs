package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        //racineC(); //Exercice1:
        //func2(); //Exercice2:
        gestionPoints();//Exercice3:
    }
    //
    public static void racineC(){
        Double choix = 0.0;
        do {
            System.out.println("Tapez \"0\" pour quitée !\nSaisire un nombre pour calculer son racine carrée :");
            Scanner sc = new Scanner(System.in);
            choix = sc.nextDouble();
            if(choix > 0){
                System.out.println(String.format("Le racine carée de %f est : %f", choix, Math.sqrt(choix)));
            }else if(choix < 0)
                System.out.println("Nombre doit etre positive !");
        }while(choix != 0);
    }
    public static void func2(){
        System.out.println("Saisir un montant : ");
        Scanner sc = new Scanner(System.in);
        Double montantD = sc.nextDouble();
        System.out.println("Nombre de mois :");
        int nbMois = sc.nextInt();
        //
        Double TM = ( montantD * (0.01 / 100) ) * nbMois;
        System.out.println(String.format("Intérêts cumulés après %d : %f", nbMois, TM));
        System.out.println(String.format("Montant finale : %f", (montantD - TM)));
    }
    public static void gestionPoints(){
        Point a = new Point(2109,131827,1037218);
        Point b = new Point(6234,198371,91312);
        Point c = new Point(1983,871938, 219);
        //
        System.out.println(a.toString());
        System.out.println(b.toString());
        System.out.println(c.toString());
    }
}
