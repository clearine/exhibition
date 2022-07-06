using System.Threading;
using System.Collections.Generic;


public class Room
{
    public List<Person> People = new List<Person>();

    public Room()
    {
        for (var i = 0; i < 20; i++)
        {
            var person = new Person();
            People.Add(new Person());
            if (person.Violent == true)
            {
                People.Remove(person);
            }
        }
    }

    public void WalkIn()
    {
        var person = new Person();
        People.Add(person);
        if (person.Violent == true)
        {
            Environment.Exit(0);
        }
        Decide(random.Next(0, People.Count));
    }

    private void Decide(int specificPerson) {
        Thread.Sleep(random.Next(5000, 10000));
        var decision = random.Next(1, 3);
        if (decision == 1)
        {
            People.RemoveAt(specificPerson);
        }
    }

    private Random random = new Random();
}