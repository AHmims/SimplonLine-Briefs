package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Merci de saisir un nombre : ");
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        //
        menu(number);
    }

    private static void menu(int number) {
        System.out.println("- Menu- \n1: Factorielle.\n2: La somme.\n0: Quitter.");
        Scanner sc = new Scanner(System.in);
        int choix = sc.nextInt();
        while(choix != 0) {
            switch (choix) {
                case 1:
                    int resF = facto(number);
                    if (resF != -1) System.out.println(String.format("Le factorielle de %d est : %d", number, resF));
                    else System.out.println(String.format("Le nombre %d n'est pas valide.", number));
                    break;
                case 2:
                    int resS = somme(number);
                    System.out.println(String.format("La somme des nombres entées est : %d", resS));
                    break;
                default:
                    System.out.println("Choix non valide");
                    menu(number);
            }
        }
        System.out.println("Programme arrêté");
    }

    //
    private static Integer facto(Integer number) {
        Integer res = 1;
        if (number > 0) {
            for (Integer i = 1; i <= number; i++) {
                res *= i;
            }
        } else if (number < 0)
            res = -1;
        return res;
    }

    //
    private static int somme(int number) {
        int res = number;
        System.out.println("Saisir le nombre des entrés : ");
        Scanner sc = new Scanner(System.in);
        int nb = sc.nextInt();
        for (int i = 0; i < nb; i++) {
            System.out.print(String.format("%d : Saisire un nombre : ", i + 1));
            res += sc.nextInt();
            System.out.print("\n");
        }
        return res;
    }
}
