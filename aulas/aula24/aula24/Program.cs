namespace aula24;

public class Program
{
    public static void Main()
    {
        Person personOne = new Person();
        personOne.Age = 14;
        personOne.Name = "Rogério";
        Console.WriteLine(personOne.IsAdult());

        Person personTwo = new Person();
        string personName = "Geraldo";
        int personAge = 34;
        Console.WriteLine(personTwo.IsAdult2(personAge, personName));
    }
}