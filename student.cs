using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Student
{
    private string studentNumber;
    private string name;
    private int mark;

    public Student(string studentNumber, string name, int mark)
    {
        this.studentNumber = studentNumber;
        this.name = name;
        this.mark = mark;
    }

    public string GetStudentNumber()
    {
        return studentNumber;
    }

    public void SetStudentNumber(string studentNumber)
    {
        this.studentNumber = studentNumber;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public int GetMark()
    {
        return mark;
    }

    public void SetMark(int mark)
    {
        this.mark = mark;
    }

    public string GetGrade()
    {
        if (mark >= 0 && mark < 40)
        {
            return "F";
        }
        else if (mark >= 40 && mark < 50)
        {
            return "E";
        }
        else if (mark >= 50 && mark < 60)
        {
            return "D";
        }
        else if (mark >= 60 && mark < 70)
        {
            return "C";
        }
        else if (mark >= 70 && mark < 80)
        {
            return "B";
        }
        else if (mark >= 80 && mark <= 100)
        {
            return "A";
        }
        else
        {
            return "Invalid mark";
        }
    }
}

