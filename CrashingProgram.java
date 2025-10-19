import java.util.Scanner;

public class CrashingProgram {
    public static void main(String[] args) {
        int[] myIntArray = new int[5];

        for(int i = 0; i <= 5; i++){
            myIntArray[i] = 100/i;
            System.out.println(myIntArray[i]);
        }

        Scanner sc = new Scanner(System.in);
        System.out.println("Please input a number between 1 - 5: ");
        int number = sc.nextByte();
        System.out.println("Your input was: " + number);

        sc.close();
    }
}
