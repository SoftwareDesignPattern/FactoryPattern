using System;

namespace FactoryPattern.Entityes
{
    class Consultant : IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ConactNo { get; set; }
        public long NID { get; set; }
        public string MobileNo { get; set; }
    }
}
