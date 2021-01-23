package com.company;

import java.util.Calendar;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        menu();
    }
    private static void menu() {
        int choix = -1;
        while (choix != 0) {
            System.out.println("- Menu- \n1: Exercice 1_1.\n2: Exercice 1_2.\n3: Exercice 2.\n4: Exercice 3.\n0: Quitter.");
            Scanner sc = new Scanner(System.in);
            System.out.print("------\nVotre choix : ");
            choix = sc.nextInt();
            //
            switch (choix) {
                case 1:
                    exercice1();
                    break;
                case 2:
                    exercice2();
                    break;
                case 3:
                    exercice3();
                    break;
                case 4:
                    exercice4();
                    break;
                default:
                    System.out.println("Choix non valide");
                    menu();
            }
        }
        System.out.println("Programme arrêté");
    }
    //
    public static void exercice1() {
        Employe[] employes = new Employe[3];
        //
        employes[0] = new Employe("El alami", "Mohammad", "Casablanca", 1963, 2020);
        employes[1] = new Employe("El wahabi", "Khalid", "Safi", 1990, 2020);
        employes[2] = new Employe("Sbai", "Fouad", "Salé", 2006, 2020);
        //
        for (Employe employe : employes) {
            if (employe == null)
                break;
            System.out.println(employe.afficherInfosClient());
            System.out.printf("Age : %dans\n", employe.calculerAge());
            System.out.println("---");
        }
    }

    //
    public static void exercice2() {
        Article article = new Article("Article 1", 536.69);
        ArticleEnSolde enSolde = new ArticleEnSolde(article, 20);
        //
        System.out.println(article.afficher());
        System.out.println(enSolde.afficher());
    }

    //
    public static void exercice3() {
        Employe employe = new Employe("El alami", "Mohammad", "Casablanca", 1963, 2020);
        CompteBancaire compteBancaire = new CompteBancaire(employe, Long.parseLong("87236"), 10000.00);
        CompteEpargne compteEpargne = new CompteEpargne(compteBancaire, 2.5);
        //
        compteBancaire.Ajouter(200.00);
        compteBancaire.Retirer(50.00);
        System.out.println(compteBancaire.Afficher());
        //
        compteEpargne.calculerInterer();
    }

    //
    public static void exercice4() {
        Calendar dateN = Calendar.getInstance();
        dateN.set(1978, Calendar.MARCH, 20);
        Secretaire secretaire_1 = new Secretaire("El wahbi", "Sanaa", "Adresse", "Safi", dateN, "001");
        Secretaire secretaire_2 = new Secretaire("Alami", "Ahmed", "Adresse", "Safi", dateN, "002");
        //
        System.out.println(secretaire_1.toString());
        System.out.println(secretaire_2.toString());
        System.out.println("-----");
        secretaire_1.modifiePersonne("Adrs","Fes");
        System.out.println(secretaire_1.toString());
        System.out.println("-----");
        secretaire_1.ecrirePersonne();
    }
}
