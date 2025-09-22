public class lecturesExcercises {
    public static void main (String[] args) {
        DistanceConverter dc = new DistanceConverter();
        
        double distanceToKilometers = dc.milesToKilometers();
    }
   
    
    
    static double milesToKilometers() {
        double miles = 100;
        double kilometers = miles * 1.609344;
        return kilometers;
    }
}
