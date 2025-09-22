public class Unicorn {
    private int age;
    String colour, mood;
    boolean horn, alive;

    Unicorn(int age, String colour, String mood, boolean alive, boolean horn) {
        this.age = age;
        this.colour = colour;
        this.mood = mood;
        this.horn = horn;
        this.alive = alive;
    }

    void setAge(int age) {
        this.age = age;
    }
    
    int getAge(){
        return age;
    }

    void runWild() {}
}