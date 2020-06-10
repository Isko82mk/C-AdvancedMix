using InterfacesAndAbstracts.Enteties;
using System;
using System.Collections.Generic;

namespace InterfacesAndAbstracts
{
    class Program
    {
        static void Main(string[] args)
        {

            Student isko = new Student()
            {
                Grades = new List<int> { 7,8,9 },
                Id = 1,
                Name = "Ivica",
                Username="isko@82",
                Password=123,
            };

              isko.PrintUser(isko);
             

            Teacher deki = new Teacher()
            {
                Id = 2,
                Name = "Dejan",
                Username = "deki@98",
                Password = 456,
                Subject = "C#",
            };

            deki.PrintUser(deki);


            Console.ReadLine();
        }
    }
}
