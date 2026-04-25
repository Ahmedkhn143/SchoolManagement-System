using System;

namespace School_Management_System.Models
{
    /// <summary>
    /// Base class representing common person information.
    /// Demonstrates encapsulation, inheritance and polymorphism.
    /// </summary>
    public abstract class Person
    {
        // Backing fields
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _contact;

        protected Person() { }

        protected Person(int id, string firstName, string lastName, string contact)
        {
            _id = id;
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
        }

        public int Id
        {
            get => _id;
            protected set => _id = value; // derived classes or repository set Id
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = (value ?? string.Empty).Trim();
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = (value ?? string.Empty).Trim();
        }

        public string Contact
        {
            get => _contact;
            set => _contact = (value ?? string.Empty).Trim();
        }

        public string FullName => string.IsNullOrWhiteSpace(LastName) ? FirstName : $"{FirstName} {LastName}";

        /// <summary>
        /// Polymorphic method. Derived classes override to show role specific info.
        /// </summary>
        public virtual string GetProfile()
        {
            return $"{FullName} (Contact: {Contact})";
        }
    }
}
