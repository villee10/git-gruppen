namespace git_gruppen;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public  Person()
    {
       
    }

    public void AddPerson(Person person)
    {
        Console.WriteLine("Lägg till en person");
        string? newPerson = Console.ReadLine();
        Console.WriteLine($"Du har lagt till {person.Name}");
    }
}