


// Student Marks Management System

class Test
{
    public static void Main()
    {

        //// PART - A
        // int[] marks = { 78, 65, 92, 55, 88, 41, 73, 96 };

        // for (int i = 0; i < marks.Length; i++)
        // {
        //     System.Console.WriteLine($"Student {i + 1} : {marks[i]}");
        // }

        // System.Console.WriteLine($"\nTotal number of students : {marks.Count()}");

        // int totalMarks = marks.Sum();
        // System.Console.WriteLine($"Total marks : {totalMarks}");

        // decimal average = totalMarks / 8;
        // System.Console.WriteLine($"Average marks : {average}");

        // int max = marks[0];
        // foreach (int mark in marks)
        // {
        //     if (mark > max)
        //     {
        //         max = mark;
        //     }
        // }

        // System.Console.WriteLine($"Highest mark : {max}");

        // int min = marks[0];
        // foreach (int mark in marks)
        // {
        //     if (mark < min)
        //     {
        //         min = mark;
        //     }
        // }

        // System.Console.WriteLine($"Lowest mark : {min}");

        // int count = 0;
        // foreach (int mark in marks)
        // {
        //     if (mark > 40)
        //     {
        //         count += 1;
        //     }
        // }
        // System.Console.WriteLine($"Passed student : {count}");

        // // PART - B

        List<int> marks = new List<int>
        {
            78, 65, 92, 55, 88, 41, 73, 96
        };

        System.Console.WriteLine($"===== ORIGINAL LIST =====");
        foreach (int mark in marks)
        {
            System.Console.WriteLine(mark);
        }
        System.Console.WriteLine($"\nTotal students : {marks.Count}");

        marks.Add(84);
        marks.Add(69);

        System.Console.WriteLine($"\n===== AFTER ADDING NEW STUDENTS =====");
        foreach (int mark in marks)
        {
            System.Console.WriteLine(mark);
        }
        System.Console.WriteLine($"\nTotal students : {marks.Count}");

        marks.Remove(41);
        System.Console.WriteLine($"\n===== AFTER REMOVING 41 =====");
        foreach (int mark in marks)
        {
            System.Console.WriteLine(mark);
        }
        System.Console.WriteLine($"\nTotal students : {marks.Count}");

        int total = marks.Sum();
        System.Console.WriteLine($"\nTotal marks : {total}");

        decimal average = total / marks.Count;
        System.Console.WriteLine($"Average Marks : {average}");

        int max = marks[0];
        foreach (int mark in marks)
        {
            if (mark > max)
            {
                max = mark;
            }
        }
        System.Console.WriteLine($"Highest Mark : {max}");

        int min = marks[0];
        foreach (int mark in marks)
        {
            if (mark < min)
            {
                min = mark;
            }
        }
        System.Console.WriteLine($"Lowest Mark : {min}");

        int count = 0;
        foreach (int mark in marks)
        {
            if (mark > 40)
            {
                count += 1;
            }
        }
        System.Console.WriteLine($"Passed students : {count}");

        bool exist = marks.Contains(92);
        System.Console.WriteLine($"Student with 92 marks exists : {exist}");

        System.Console.WriteLine($"\n===== MARK ANALYSIS =====");
        int x1 = 0;
        int x2 = 0;
        int x3 = 0;
        int x4 = 0;
        int x5 = 0;
        int x6 = 0;
        foreach (int mark in marks)
        {
            if (mark >= 90)
            {
                x1 += 1;
            }
            else if (mark >= 80)
            {
                x2 += 1;
            }
            else if (mark >= 70)
            {
                x3 += 1;
            }
            else if (mark >= 60)
            {
                x4 += 1;
            }
            else if (mark >= 50)
            {
                x5 += 1;
            }
            else if (mark < 50)
            {
                x6 += 1;
            }
        }

        System.Console.WriteLine($"90-100 : {x1} students");
        System.Console.WriteLine($"80-89 : {x2} students");
        System.Console.WriteLine($"70-79 : {x3} students");
        System.Console.WriteLine($"60-69 : {x4} students");
        System.Console.WriteLine($"50-59 : {x5} students");
        System.Console.WriteLine($"Below 50 : {x6} students");

    }
}