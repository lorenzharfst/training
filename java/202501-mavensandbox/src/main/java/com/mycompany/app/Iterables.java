package com.mycompany.app;

import java.util.List;

public class Iterables<T> {
    List<T> list;
    public Iterables(List<T> list){
        this.list = list;
    }

    // Run random shit on the List to test stuff
    public void run(){
        for (T element: list){
            System.out.println(element);
        }
    }
}
