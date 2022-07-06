public class Room
{
    public List<Person> People = new List<Person>();

    public Room()
    {
        for (var i = 0; i < 50; i++)
        {
            var person = new Person();
            People.Add(new Person());
            if (person.Violent == true)
            {
                People.Remove(person);
            }
        }
    }
}