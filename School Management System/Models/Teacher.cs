using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management_System.Models
{
    public class Teacher : Person
    {
        private string _subject;
        private List<string> _assignedClasses = new List<string>();

        public Teacher() : base() { }

        public Teacher(int id, string firstName, string lastName, string subject, IEnumerable<string> assignedClasses, string contact)
            : base(id, firstName, lastName, contact)
        {
            Subject = subject;
            AssignedClasses = assignedClasses?.ToList() ?? new List<string>();
        }

        public string Subject
        {
            get => _subject;
            set => _subject = (value ?? string.Empty).Trim();
        }

        public IReadOnlyList<string> AssignedClasses => _assignedClasses.AsReadOnly();

        public void AssignClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className)) return;
            if (!_assignedClasses.Contains(className.Trim()))
                _assignedClasses.Add(className.Trim());
        }

        public void UnassignClass(string className)
        {
            if (string.IsNullOrWhiteSpace(className)) return;
            _assignedClasses.Remove(className.Trim());
        }

        public override string GetProfile()
        {
            var classes = AssignedClasses.Any() ? string.Join(", ", AssignedClasses) : "None";
            return $"{FullName} | Subject: {Subject} | Classes: {classes} | Contact: {Contact}";
        }

        public override string ToString() => GetProfile();
    }
}
