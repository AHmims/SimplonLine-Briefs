package com.company;

public class A {
    int x;

    public A(int x) {
        this.x = x;
    }
    //
    public A(A a) {
        this.x = a.x;
    }
}
