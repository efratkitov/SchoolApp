using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITIES;

namespace BAL
{
  
    public class functions
    {
        // עצם מסוג מחלקת דאטהבייס
        database db = new database();
        //רשימה מסוג תלמידים
        public List<student> studentsList = new List<student>();
        //רשימה מסוג מורים
        public List<teacher> teachersList = new List<teacher>();

        //פונקציה לקריאת שמות התלמידים ממסד הנתונים והמרה לרשימה רגילה
        public List<student> ReadStudents()
        {
            var reader = db.PrintStudentNames();
            while (reader.Read())
            {
                //יצירת אובייקט מסוג תלמיד
                student s = new student
                {
                    ID = reader["ID"].ToString(),
                    firstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    homePhone = reader["HomePhone"].ToString(),
                    birthdayyear = reader["BirthdayYear"].ToString(),
                    class1 = reader["Class"].ToString(),
                    address = reader["Address"].ToString()
                };
                //הוספת התלמיד לרשימה
                studentsList.Add(s);
            }
            // סגירת הקורא
            reader.Close();
            return studentsList;
        }
        //פונקציה לקריאת שמות המורים ממסד הנתונים והמרה לרשימה רגילה
        public List<teacher> Readteachers()
        {
            var reader = db.PrintSteachersNames();
            while (reader.Read())
            {
                //יצירת אובייקט מסוג מורה
                teacher t = new teacher(
                    Convert.ToInt32(reader["ID"]),
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["Phone"].ToString(),
                    reader["MailAddress"].ToString()
                );
                //הוספת המורה לרשימה
                teachersList.Add(t);
            }
            // סגירת הקורא
            reader.Close();
            return teachersList;
            
        }
    }
}
