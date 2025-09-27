public class MakeUnicorns {
    
    public static void main(String[] args) {
        Unicorn bengt = new Unicorn(5, "Blå", "Glad", true, true);
        Unicorn ilse = new Unicorn(4, "Gul", "Likgiltig", true, false);

        isThisAUnicorn(ilse);
        isThisAUnicorn(bengt);
    }

    static void isThisAUnicorn(Unicorn name) {
            System.out.println("Is this a unicorn? ");

        if (name.horn == true){
            System.out.println(name + " is a unicorn");
        }
        else{
            System.out.println(name + " is an imposter! It's just a horse with a dream!");
        }
    }
}
