// See https://aka.ms/new-console-template for more information

var room = new Room();
while (true) {
    room.WalkIn();
    Console.WriteLine(room.People.Count);
}