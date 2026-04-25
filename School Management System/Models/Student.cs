using System;

namespace School_Management_System.Models
{
    public class Student : Person
    {
        private string _className;
        private string _fatherName;

        public Student() : base() { }

        public Student(int id, string firstName, string lastName, string fatherName, string className, string contact)
            : base(id, firstName, lastName, contact)
        {
            FatherName = fatherName;
            ClassName = className;
        }

        public string FatherName
        {
            get => _fatherName;
            set => _fatherName = (value ?? string.Empty).Trim();
        }

        public string ClassName
        {
            get => _className;
            set => _className = (value ?? string.Empty).Trim();
        }

        public override string GetProfile()
        {
            return $"{FullName} | Class: {ClassName} | Father: {FatherName} | Contact: {Contact}";
        }

        public override string ToString() => GetProfile();
    }
}
