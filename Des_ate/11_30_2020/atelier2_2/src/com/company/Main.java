package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Nombre de test (1->6):");
        Scanner sc = new Scanner(System.in);
        switch (sc.nextInt()) {
            case 1:
                func_1();
                break;
            case 2:
                func_2();
                break;
            case 3:
                func_3();
                break;
            case 4:
                func_4();
                break;
            case 5:
                func_5();
                break;
            case 6:
                func_6();
                break;
            default:
                System.out.println("Nombre de test invalide!");
        }
        //func_1();
        //func_2();
        //func_3();
        //func_4();
        //func_5();
        //func_6();
    }

    private static void func_1() {
        System.out.println("Quel est votre prénom ?");
        Scanner sc = new Scanner(System.in);
        String nom = null;
        nom = sc.nextLine();
        //String nom = System.console().readLine();
        System.out.println("Bonjour, " + nom + "!");
    }

    //
    private static void func_2() {
        //System.out.println("Saisire le prix HT\nNombre d'articles\nTaux de TVA(0 -> 100)");
        Scanner sc = new Scanner(System.in);
        Double prixHT = null, prixTTC = null, TVA = null;
        Integer nbA = 1;
        System.out.println("Saisire le prix HT :");
        prixHT = sc.nextDouble();
        System.out.println("Taux de TVA(0 -> 100) :");
        TVA = sc.nextDouble();
        System.out.println("Nombre d'articles :");
        nbA = sc.nextInt();
        prixTTC = (1 + (TVA / 100)) * (prixHT * nbA);
        System.out.println("Le prix TTC est : " + prixTTC + "DH");
    }

    //
    private static void func_3() {
        String sequence = "";
        Integer max = 10;
        for (Integer i = 1; i <= max; i++) {
            sequence += i;
            if (i != max)
                sequence += ", ";
        }
        //
        System.out.println(sequence);
    }

    //
    private static void func_4() {
        String sequence = "";
        Integer max = 10;
        for (Integer i = 1; i <= max; i++) {
            sequence += i;
            if (i != max)
                sequence += ", " + (100 - (i - 1)) + ", ";
        }
        //
        System.out.println(sequence);
    }

    //
    private static void func_5() {
        String nom = "", prenom = "";
        Integer age = 0;
        //
        Scanner sc = new Scanner(System.in);
        System.out.println("Saisire votre nom :");
        nom = sc.nextLine();
        System.out.println("Saisire votre prenom :");
        prenom = sc.nextLine();
        System.out.println("Saisire votre age :");
        age = sc.nextInt();
        //
        System.out.println(retFunc(nom, prenom, age));
    }

    private static String retFunc(String nom, String prenom, Integer age) {
        return String.format("Bonjour %s %s, tu as %dans", nom, prenom, age);
    }

    //
    private static void func_6() {
        String sexe = "";
        Integer age = 0;
        Scanner sc = new Scanner(System.in);
        System.out.println("Votre sexe :(femme[F/f]/homme[H/h])");
        sexe = sc.nextLine();
        System.out.println("Votre age :");
        age = sc.nextInt();
        //
        String ret = retFunc2(sexe, age);
        if (ret != null)
            System.out.println(ret);
        else
            System.out.println("Sexe entrée non valide");
    }

    private static String retFunc2(String sexe, Integer age) {
        String choixSexe = "", choixAge = "";
        switch (sexe.toLowerCase()) {
            case "femme":
            case "f":
                choixSexe = "femme";
                break;
            case "homme":
            case "h":
                choixSexe = "homme";
                break;
            default:
                choixSexe = null;
        }
        //
        if (age < 18)
            choixAge = "mineur";
        else
            choixAge = "majeur";
        //
        if (choixSexe != null)
            return String.format("Vous êtes %s et vous êtes %s", choixSexe, choixAge);
        else
            return null;
    }
//
}