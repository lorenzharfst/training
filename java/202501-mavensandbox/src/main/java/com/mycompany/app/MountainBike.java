package com.mycompany.app;

public class MountainBike extends Bicycle {

    int seatHeight;
    String[] titles;

    public MountainBike (int cadence, int gear, int speed, int seatHeight, String... titles) {
        super(cadence, gear, speed);
        this.seatHeight = seatHeight;
        this.titles = titles;
    }
}
