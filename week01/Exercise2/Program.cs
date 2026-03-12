using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Grade Letter Calculator.");
        Console.Write("Enter your grade percentage: ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";

        if (grade >= 90)
        {
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("F");
            letter = "F";
        }    


        if (grade >= 70)
        {
            Console.WriteLine("You passed the course. Congratulations!");
        }    
        else
        {
            Console.WriteLine("Try harder next time.");
        }
        Console.WriteLine($"Your grade letter is {letter}.");
    }
}