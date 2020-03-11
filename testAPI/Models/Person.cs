﻿namespace FitnessApp.Models
{
    using System;
    using System.Text;

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Male { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, DateTime birthDate, 
                      double height, double weight, string male, DateTime registerDate, string email)
        {
            this.ID = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Height = height;
            this.Weight = weight;
            this.Male = male;
            this.RegisterDate = registerDate;
            this.Email = email;
        }

        public override string ToString()
        {
            StringBuilder b = new StringBuilder("\nID: ");
            b.Append(this.ID);
            b.Append("\tName: "); b.Append(this.Name);
            b.Append("\tBirthDate: "); b.Append(this.BirthDate);
            b.Append("\tHeight: "); b.Append(this.Height);
            b.Append("\tWeight: "); b.Append(this.Weight);
            b.Append("\tMale: "); b.Append(this.Male);
            b.Append("\tRegisterDate: "); b.Append(this.RegisterDate);
            b.Append("\tEmail: "); b.Append(this.Email);
            b.Append('\n');
            return b.ToString();
        }
    }
}