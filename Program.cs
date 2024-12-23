using System;
using System.Diagnostics;
namespace DataType
{
  public class StudentInput
  {
    public string Name()
    {
        string name ="Hasan";
        return name;
    }
  }
  class Program {
    static void Main (string[] args){

        StudentInput student = new StudentInput();
        Console.WriteLine($"Student Name is: {student.Name()}");
    }
  }
}