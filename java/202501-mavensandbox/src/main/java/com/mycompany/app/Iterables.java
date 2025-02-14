package com.mycompany.app;

import java.util.List;
import java.util.Collection;
import java.util.ArrayList;

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
        System.out.println("Test Collection instantiating ArrayList");
        Collection<String> col = new ArrayList<>();
        col.add("Herro");
        col.add("Hiya");
        System.out.println(col);
        Collection<String> col2 = new ArrayList<>();
        col2.add("Herro");
        col2.add("Hey");
        System.out.println("Does col contain everything in col2? " + col.containsAll(col2));
        System.out.println("Adding all elements of col2 into col");
        col.addAll(col2);
        System.out.println("Does col contain everything in col2? " + col.containsAll(col2));
        System.out.println("Collection col: " + col);
        System.out.println("Copying to an array with toArray(), using a 0 length array since it will automatically create a correct size and return that");
        String[] resultArray = col.toArray(String[]::new);
        System.out.println("Attempting to create a List out of an array");
        String[] stringArray = { "stringEl1", "stringEl2", "stringEl3" };
        List<String> stringList = List.of(stringArray);
        System.out.println("Resulting List " + stringList);
    }
}
