package Vehicles;

public class Landbaserade extends Fordon {
    
    public static void main(String[] args) {
        Landbaserade bil = new Landbaserade(5000);
        bil.price;
        bil.toString();
    }

    Landbaserade(int pris){
        this.price=pris;
    }


    @Override
    public void runVehicle(){

    }
}
