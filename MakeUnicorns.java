public class MakeUnicorns {
    
    public static void main(String[] args) {
        Unicorn bengt = new Unicorn(5, "Blå", "Glad", true, true);
        Unicorn ilse = new Unicorn(4, "Gul", "Likgiltig", true, true);
/* 
        System.out.println("This is Bengt: ");
        System.out.println(bengt.getAge());
        bengt.setAge(6);
        System.out.println(bengt.getAge());
*/
        
        System.out.println("Is this a unicorn? ");

        if (ilse.horn == true){
            System.out.println("Ilse is a unicorn");
        }
        else{
            System.out.println("Ilse is an imposter! She is just a horse with a dream!");
        }
    }
}
