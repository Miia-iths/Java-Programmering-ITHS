package sol;

import java.util.Scanner;

public class DistanceConverterOther {
    public static void main (String[] args) {
        System.out.println("Please input a distance to convert (miles):");
        Scanner scan = new Scanner(System.in);
        double distance = scan.nextDouble();

        milesToKilometers(distance);
    }
    
    static void milesToKilometers (double miles) {
        double kilometers = miles * 1.60934;
        System.out.println(kilometers);
    }

    static void kilometersToMiles (double kilometers) {
        double miles = kilometers / 1.60934;
        System.out.println(miles);
    }

    /* 
    public static void main (String[] args) {
        DistanceConverter dc = new DistanceConverter();
        
        double distanceToKilometers = dc.milesToKilometers();
    }

    static double milesToKilometers() {
        double miles = 100;
        double kilometers = miles * 1.609344;
        return kilometers;
    }*/
    }

