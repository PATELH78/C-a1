using System;

class Program
{
    static void Main(string[] args)
    {
        var student1 = CreateStudent(1, StudentType.FullTime, "John", "Anderson");
        var student2 = CreateStudent(2, StudentType.FullTime, "Karin", "Smith");
        var student3 = CreateStudent(3, StudentType.FullTime, "Kevin", "Peters");

        Console.WriteLine("Assignment one");
        OutputStudent(student1);
        OutputStudent(student2);
        OutputStudent(student3);
    }

    static Student CreateStudent(int id, StudentType type, string firstName, string lastName)
    {
        if (id == null)
            id = 0;
        if (firstName == null)
            firstName = "Unknown";
        if (lastName == null)
            lastName = "";

        return new Student
        {
            Id = id,
            Type = type,
            FirstName = firstName,
            LastName = lastName
        };
    }

    static void OutputStudent(Student student)
    {
        string typeString = student.Type.ToString();
        string typeOutput = char.ToUpper(typeString[0]) + typeString.Substring(1); // Capitalize first letter
        Console.WriteLine($"Student: {student.Id:D3} {student.FirstName} {student.LastName} ({typeOutput})");
    }
}
