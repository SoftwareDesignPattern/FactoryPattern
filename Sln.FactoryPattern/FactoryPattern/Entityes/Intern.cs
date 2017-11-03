using System;

namespace FactoryPattern.Entityes
{
    class Intern : IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ConactNo { get; set; }
    }
}
