public class Person {
    public Person() {
        int number = random.Next(0, 100);
        if (number == 1) { Violent = true ;}
    }
    public bool Violent;
    Random random = new Random();
}