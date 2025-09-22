import java.util.Scanner;

public class MT25GameVariables{

    public static void main(String[] args) {
        String characterName;
        String className;
        int level = 0;
        
        try (Scanner scan = new Scanner(System.in)){
            System.out.println("What is your name?");
            characterName = scan.nextLine();
            System.out.println("What is your class?");
            className = scan.nextLine();
            System.out.println("Your name is "+ characterName +"\nand your class is " + className);
            System.out.println("Your level is: " + level);
        }
        if (level < 1){
            System.out.println("You are not prepared! ...to adventure...");
        }
        else {
            System.out.println("Go out and have fun dear!");
        }
    }
}
