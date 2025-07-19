namespace Encapsulation;

public class Student
{
    private string Name;
    private int Age;

    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        if (age < 0 || age >= 150)
        {
            throw new ArgumentException("Age is wrong");
        }

        Age = age;
    }
}
