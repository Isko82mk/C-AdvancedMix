using InterfacesAndAbstracts.Interfaces;
using System;

namespace InterfacesAndAbstracts.Enteties
{
    public class Teacher : User, ITeacher
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Username { get; set; }
        public override int Password { get; set; }
        public string Subject { get; set; }

        public Teacher()
        {

        }

        public override void PrintUser(IUser user)
        {
            Console.WriteLine($"{Subject}");
        }
    }
}
