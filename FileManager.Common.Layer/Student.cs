using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Layer
{
    public class Student
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _ageOfBirth;

        public Student(int Id, string Name, string Surname, int AgeOfBirth)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.AgeOfBirth = AgeOfBirth;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int AgeOfBirth { get => _ageOfBirth; set => _ageOfBirth = value; }
    }
}
