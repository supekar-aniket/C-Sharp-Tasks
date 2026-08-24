class Student
{
    private string? name;
    private int age;
    private string? course;

    public Student(string name, int age, string course)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name is required...!");
        }
        this.name = name;

        if (age <= 0)
        {
            throw new ArgumentException("Age should be greater than 0....!");
        }
        this.age = age;

        if (string.IsNullOrWhiteSpace(course))
        {
            throw new ArgumentException("Course name is required...!");
        }
        this.course = course;
    }

    // Calls the main constructor with a default course.
    public Student(string name, int age) : this(name, age, "Not Assigned")
    {
    }

    // Calls the main constructor with default values.
    public Student() : this("Unknown", 18, "Not Assigned")
    {
    }

    public void DisplayDetails()
    {
        System.Console.WriteLine("Student Name : " + name);
        System.Console.WriteLine("Student Age : " + age);
        System.Console.WriteLine("Course Name : " + course);
    }

}

class Test
{
    public static void Main()
    {
        Student s1 = new Student("Aniket", 24, "MCS");
        Student s2 = new Student("Vedant", 22);
        Student s3 = new Student();

        System.Console.WriteLine("\n --- Student 1 ---");
        s1.DisplayDetails();

        System.Console.WriteLine("\n --- Student 2 ---");
        s2.DisplayDetails();

        System.Console.WriteLine("\n --- Student 3 ---");
        s3.DisplayDetails();
    }
}