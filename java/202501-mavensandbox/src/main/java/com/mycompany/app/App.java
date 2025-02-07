package com.mycompany.app;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import com.mycompany.app.Iterables;

public class App {
    public static void main(String[] args) {
        System.out.println("This is App.class");

        int[] intArray = new int[10];
        System.out.println(intArray.length);
        int[] secondIntArray = { 1, 2, 3, 4 }; 
        System.out.println(secondIntArray.length);
        System.out.println(java.util.Arrays.toString(secondIntArray));
        int[] thirdIntArray = new int[2];
        System.arraycopy(secondIntArray, 0, thirdIntArray, 0, 2);
        System.out.println(thirdIntArray.length);

        for (var number: secondIntArray) {
            System.out.print(number + " ");
        }

        boolean exit = false;
        Scanner scanner = new Scanner(System.in);
        while (!exit) {
            Utils.printLines("Choose an action:", "1. Say hi!", "2. Exit");
            String userInput = scanner.nextLine();
            switch (userInput) {
                case "1" -> System.out.println("Hi!");
                case "2" -> exit = true;
            }
        }
        scanner.close();

        String[] names = { "Pop", "Rob", "Coc", "Top" };
        List<String> nameList = new ArrayList<>();

        for (String name: names) {
            nameList.add(name);
        }

        Iterables<String> stringIterables = new Iterables<>(nameList);
        stringIterables.run();

    }
}

class Utils {
    public static void printLines(String... lines) {
        for (String line: lines) {
            System.out.println(line);
        }
    }
}
