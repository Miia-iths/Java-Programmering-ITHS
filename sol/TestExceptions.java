import java.util.*;

public class TestExceptions {
    public static void main(String[] args) {
       try {
            int result = 10/0;
       } catch (ArithmeticException e) {
        System.out.println("kaos" + e.getMessage());
       }
       
       
       
    }
}
    

