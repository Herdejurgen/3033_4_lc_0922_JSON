// var

string nameStr = "Jack";

string result = AddFunctionToString.FirstLast(nameStr);
string result2 = nameStr.FirstLast();
Console.WriteLine(result2);

var nameStrCard2 = nameStr;

var age = 20;

var stu1 = new Student{ age=24,name=nameStr};
var stu2 = new Student(23, "Kate");

var p1 = new { name = "Aiden", weight = 154.3 };
var anon = p1.name;

Console.ReadLine();

public class Student
{
    public string name { get; set; }
    public int age { get; set; }
    public Student()
    {

    }
    public Student(int age, string name)
    {        
        this.age = age;
        this.name = name;
    }
}
public static class AddFunctionToString // Adding this below adds it to all strings
{
    public static string FirstLast(this string str)
    {
        return string.Format($"{str[0]}{str[str.Length-1]}");
    }
}