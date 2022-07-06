var random = new Random();
var room = new Room();
while (true) {
    WalkIn();
    Console.WriteLine(room.People.Count);
    for (var i = 0; i < 3; i++)
    {
        Decide(room.People[random.Next(1, room.People.Count)]);
    }
}

void WalkIn()
{
    var person = new Person();
    room.People.Add(person);
    if (person.Violent == true)
    {
        Environment.Exit(0);
    }
}

void Decide(Person person) {
    Thread.Sleep(random.Next(3000, 5000));
    var decision = random.Next(1, 3);
    if (decision == 1)
    {
        room.People.Remove(person);
    }
}