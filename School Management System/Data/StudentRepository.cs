using System;
using System.Data;
using System.Data.SqlClient;
using School_Management_System.Models;

namespace School_Management_System.Data
{
    public class StudentRepository
    {
        private readonly DatabaseHelper _db;

        public StudentRepository(DatabaseHelper db = null)
        {
            _db = db ?? new DatabaseHelper();
        }

        public DataTable GetAll()
        {
            // Return students with a stable id column name StudentId
            string sql = "SELECT Id AS StudentId, FullName, FatherName, Contact FROM Students";
            return _db.ExecuteDataTable(sql);
        }

        public int Insert(Student s)
        {
            string sql = "INSERT INTO Students (FullName, FatherName, Contact) VALUES (@fn, @father, @contact)";
            var p1 = DatabaseHelper.CreateParam("@fn", s.FullName);
            var p2 = DatabaseHelper.CreateParam("@father", s.FatherName);
            var p3 = DatabaseHelper.CreateParam("@contact", s.Contact);
            return _db.ExecuteNonQuery(sql, p1, p2, p3);
        }

        public int Update(Student s)
        {
            string sql = "UPDATE Students SET FullName=@fn, FatherName=@father, Contact=@contact WHERE Id=@id";
            var p1 = DatabaseHelper.CreateParam("@fn", s.FullName);
            var p2 = DatabaseHelper.CreateParam("@father", s.FatherName);
            var p3 = DatabaseHelper.CreateParam("@contact", s.Contact);
            var p4 = DatabaseHelper.CreateParam("@id", s.Id);
            return _db.ExecuteNonQuery(sql, p1, p2, p3, p4);
        }

        public int Delete(int studentId)
        {
            string sql = "DELETE FROM Students WHERE Id=@id";
            var p = DatabaseHelper.CreateParam("@id", studentId);
            return _db.ExecuteNonQuery(sql, p);
        }
    }
}
