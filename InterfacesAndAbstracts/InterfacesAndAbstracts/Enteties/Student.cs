using InterfacesAndAbstracts.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfacesAndAbstracts.Enteties
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Username { get; set; }
        public override int Password { get; set; }

        public Student(){}

        public override void PrintUser(IUser user)
        {
            foreach (var g in Grades)
            {
                Console.WriteLine($"{g}");

            }

        }
    }
}
