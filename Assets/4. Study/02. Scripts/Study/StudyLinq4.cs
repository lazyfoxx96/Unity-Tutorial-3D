using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinq4 : MonoBehaviour
{
    #region Data Class
    [System.Serializable]
    public class Student
    {
        public int studentID;
        public string studentName;

        public Student(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }
    }

    [System.Serializable]
    public class Grade
    {
        public int studentID;
        public int score;
        public string subject;

        public Grade(int studentID, int score, string subject)
        {
            this.studentID = studentID;
            this.score = score;
            this.subject = subject;
        }
    }
    #endregion

    public List<Student> students = new List<Student>();
    public List<Grade> grades = new List<Grade>();

    void Start()
    {
        #region Add Data
        students.Add(new Student(1, "Alice"));
        students.Add(new Student(2, "Bob"));
        students.Add(new Student(3, "Charlie"));
        students.Add(new Student(4, "Eve"));

        grades.Add(new Grade(1, 90, "Math"));
        grades.Add(new Grade(2, 85, "Science"));
        grades.Add(new Grade(3, 92, "English"));
        grades.Add(new Grade(4, 76, "Math"));
        #endregion

        InnerJoin();
    }

    private void InnerJoin()
    {
        var innerJoin = from student in students
                        join grade in grades on student.studentID equals grade.studentID
                        select new
                        {
                            StudentID = student.studentID,
                            StudentName = student.studentName,
                            Subject = grade.subject,
                            Score = grade.score
                        };

        foreach (var person in innerJoin)
        {
            Debug.Log($"ID : {person.StudentID} / Name : {person.StudentName} / Subject : {person.Subject} / Score : {person.Score}");
        }
    }
}
