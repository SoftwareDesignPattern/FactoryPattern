using System;


namespace FactoryPattern.Entityes
{
    interface IEmployee
    {
        string Name { set; get; }
        string Email { set; get; }
        DateTime DateOfBirth { set; get; }
        string ConactNo { set; get; }
    }
}