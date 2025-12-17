namespace aula24;

public class Person
{
    public string? Name;
    public int Age;

    public string IsAdult()
    {
        if (Age >= 18)
        {
            return $"{Name} é maior de idade!!";
        }
        else
        {
            return $"{Name} é menor de idade!!";
        }
    }

    public string IsAdult2(int age, string name)
    {
        if (age >= 18)
        {
            return $"{name} é maior de idade!!";
        }
        else
        {
            return $"{name} é menor de idade!!";
        }
    }
}