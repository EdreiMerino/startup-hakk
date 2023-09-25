// See https://aka.ms/new-console-template for more information
using Task3_emerino;

public class StudentProfessorTest
{
    static void Main(string[] args)
    {
        // Make a new character say hello by creating him. 
        var newCharacter = new Person();
        Console.WriteLine(newCharacter.Greet());


        // Make a new Student, give her an age, introduce yourself and show her age on the screen.
        var newStudent = new Student();
        var studentAge = newStudent.SetAge(18);
        Console.WriteLine(newStudent.Greet());
        Console.WriteLine(newStudent.ShowAge(studentAge));

        //Make a new Teacher, choose an age, introduce yourself, and begin
        //the explanation.
        var newTeacher = new Professor();
        var teacherAge = newTeacher.SetAge(30);
        Console.WriteLine(newTeacher.Greet());
        Console.WriteLine(newTeacher.Explain());


    }
}

//Make a new C# project with three classes and an additional class to test your code's logic.
//The following classes make up the program's core curriculum: 

//Person                                                                    Done
//Student                                                                   Done
//Professor                                                                 Done


//The Person class is an ancestor of the Student and Teacher classes.       Done

//I'm studying will be displayed on the screen using the public Study()     
//function of the Student class.                                            Done

//Two public methods, Greet() and SetAge(int age), that will assign the
//person's age, must be included in the Person class.                       Done

//A public Explain() function in the Teacher class will display I'm
//explaining on the screen.                                                 Done

//Make a public method as well.The Student class's ShowAge() method
//writes My age is displayed as being x years old.                          Done



//To accomplish the following, you must construct a new test class
//called StudentProfessorTest with a Main function.                         Done

//Make a new character say hello by creating him.                           Done

//Make a new Student, give her an age, introduce yourself and show
//her age on the screen.                                                    Done                                                    Done

//Make a new Teacher, choose an age, introduce yourself, and begin
//the explanation.                                                          Done