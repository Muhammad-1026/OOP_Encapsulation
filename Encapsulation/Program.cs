using Encapsulation;

Student student = new Student();

student.SetName("John Doe");
student.SetAge(20);

Console.WriteLine($"Name: {student.GetName()}");
Console.WriteLine($"Age: {student.GetAge()}");
