public class LetsMath {
    public static void main(String[] args) {
        
        // Skapa array
        int[] numbers = new int[10];

        // Fyller array med 1 -> 10
        for (int i = 0; i < 10; i++) {
            numbers[i] = i + 1;
        }

        // Läser array och printar innehåll, baklänges
        for (int j = 9; j >= 0 ; j--){
        System.out.println(numbers[j]);
        }

        // Enhanced for loop för att printa innehåll
        for(int k : numbers){
            System.out.println(numbers[k-1]);
        }
    }
}
