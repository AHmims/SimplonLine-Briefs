package com.company;

public class C extends B {
    int z;
    public C(int x, int y, int z, int j){
        super(x,y, j);
        this.z = z;
    }
    //
    public C(B b, int z){
        super(b);
        this.z = z;
    }
}
