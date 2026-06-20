using System;

class Student
{
    public int id;
    public string name;
    public string grade;
}

class StudentView
{
    public void displayStudentDetails(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("ID: " + student.id);
        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Grade: " + student.grade);
    }
}

class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void setStudentName(string name)
    {
        model.name = name;
    }

    public void setStudentGrade(string grade)
    {
        model.grade = grade;
    }

    public void updateView()
    {
        view.displayStudentDetails(model);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.id = 101;
        student.name = "Jayesh";
        student.grade = "A";

        StudentView view = new StudentView();

        StudentController controller =
            new StudentController(student, view);

        Console.WriteLine("Original Details");
        controller.updateView();

        controller.setStudentName("Rahul");
        controller.setStudentGrade("A+");

        Console.WriteLine("\nUpdated Details");
        controller.updateView();
    }
}
