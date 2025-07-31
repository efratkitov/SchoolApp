using System;
using System.Data.SQLite;


namespace DAL
{
    public class database
    {
        // פונקציה לשליפת נתונים מהטבלה Students
        public SQLiteDataReader PrintStudentNames()
        {
            var conn = new SQLiteConnection("Data Source=C:/Users/User/Desktop/c#/שיעור 9 Sqlite/schoolDB.db");
                conn.Open();
                var command = new SQLiteCommand("SELECT * FROM Students", conn);
                var reader = command.ExecuteReader();
                return reader;
               
        }

        // פונקציה לשליפת נתונים מהטבלה teachers
        public SQLiteDataReader PrintSteachersNames()
        {
             var conn = new SQLiteConnection("Data Source=C:/Users/User/Desktop/c#/שיעור 9 Sqlite/schoolDB.db");
            
                conn.Open();
                var command = new SQLiteCommand("SELECT * FROM teachers", conn);
                var reader = command.ExecuteReader();
                return reader;
            
        }


    }
}
