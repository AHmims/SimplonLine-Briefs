package com.company;

public class B extends A {
    int y;
    int x;
    public B(int x, int y, int j) {
        super(x);
        this.y = y;
        this.x = j;
    }

    public B(A a, int y, int j) {
        super(a);
        this.y = y;
        this.x = j;
    }
    //
    public B(B b){
        super(b);
        this.y = b.y;
        this.x = b.x;
    }
}
