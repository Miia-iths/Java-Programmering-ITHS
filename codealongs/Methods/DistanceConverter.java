package codealongs.Methods;

import java.util.Scanner;

public class DistanceConverter {
    public static void main(String[] args) {
        System.out.println("Please input a distance to convert (miles):");
        Scanner scan = new Scanner(System.in);
        double distance = scan.nextDouble();

        milesToKilometers(distance);
        scan.close();
    }

    static void milesToKilometers(double miles) {
        double kilometers = miles * 1.60934;
        System.out.println(kilometers);
    }

    static void kilometersToMiles(double kilometers) {
        double miles = kilometers / 1.60934;
        System.out.println(miles);

    }
    
}
