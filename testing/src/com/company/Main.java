package com.company;

public class Main {

    public static void main(String[] args) {
        A a = new A(1);
        B b = new B(a, 2,99);
        C c = new C(b,3);
        //
        System.out.println(((A)c).x);
        System.out.println(c.x);
    }
}
