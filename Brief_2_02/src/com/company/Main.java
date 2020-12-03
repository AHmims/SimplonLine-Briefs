package com.company;

import java.util.Scanner;

public class Main {
    private static Account[] accounts = new Account[999];

    //
    public static void main(String[] args) {
        menu();
    }

    //
    public static void menu() {
        int choix = -1;
        while (choix != 0) {
            System.out.println("- Menu- \n1: Exercice 1.\n2: Exercice 2.\n3: Exercice 3.\n4: Exercice 4.\n5: Exercice 5.\n8: Exercice 8.\n7: Exercice 7.\n0: Quitter.");
            Scanner sc = new Scanner(System.in);
            System.out.print("------\nVotre choix : ");
            choix = sc.nextInt();
            //
            if (choix >= 3 && choix <= 6)
                gestionClients();
            switch (choix) {
                case 1:
                    gestionPoints();
                    break;
                case 2:
                    gestionChiens();
                    break;
                case 3:
                    break;
                case 4:
                    gestionSolde();
                    break;
                case 5:
                    afficherAccounts();
                    break;
                case 6:
                    modifierSolde();
                    break;
                case 7:
                    gestionDiplomes();
                    break;
                default:
                    System.out.println("Choix non valide");
                    menu();
            }
        }
        System.out.println("Programme arrêté");
    }

    //
    public static void gestionPoints() {
        TestPoint tp = new TestPoint();
        tp.main();
    }

    //
    public static void gestionChiens() {
        Chien rex = new Chien("Rex");
        Chien max = new Chien("Max");
        //
        rex.aboyer("Je suis en colère. Ghhhhhhhhhh !!! WWWWOARF !! WWWWOARF !!");
        rex.manger("Je mange de la viande");
        //
        max.aboyer("Je ne suis pas du tout en colère. Iwiw !! awaw !!");
        max.manger("Je mange du poisson");
    }

    //
    public static void gestionClients() {
        accounts[0] = new Account("El Alami Hassan", "Safi", 14765.80, "out.println");
        accounts[1] = new Account("Karimi Khalid", "Casablanca", 7654.00, "out.printf");
        //
        accounts[0].afficher();
        accounts[1].afficher();
    }

    //
    public static void gestionSolde() {
        Account account = accounts[0];
        Double nSolde = account.calculerInterer(0.7);
        System.out.println("voulez-vous valider ce changement ? (Oui / Non)");
        Scanner sc = new Scanner(System.in);
        switch (sc.nextLine().toLowerCase()) {
            case "o":
            case "oui":
            case "y":
            case "yes":
                account.setSolde(nSolde);
                System.out.printf("Succès\nNouvelle valeur :\n");
                account.afficherInfosSolde();
                break;
            default:
                System.out.println("Valeur n'a pas été modifiée");
        }
    }

    //
    public static void afficherAccounts() {
        System.out.println("------------");
        for (Account account : accounts) {
            if (account != null)
                account.afficher();
            else break;
        }
    }

    //
    public static void modifierSolde() {
        System.out.print("Montant à retirer : ");
        Scanner sc = new Scanner(System.in);
        Account account = accounts[0];
        if (!account.retirer(sc.nextDouble()))
            modifierSolde();
    }

    //
    public static void gestionDiplomes() {
        System.out.println("Merci de saisir les informations de diplome :");
        Scanner sc = new Scanner(System.in);
        System.out.print("Titre : ");
        String titre = sc.nextLine();
        System.out.print("Mention : ");
        String mention = sc.nextLine();
        System.out.print("Anobtenu : ");
        int anobtenu = sc.nextInt();
        //
        Diplome diplome = new Diplome(titre, mention, anobtenu);
        System.out.printf("Titre : %s, Mention : %s, Anbobtenu : %d.", diplome.getTitre(), diplome.getMention(), diplome.getAnobtenu());
    }
}
