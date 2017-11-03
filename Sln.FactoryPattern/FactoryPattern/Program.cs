using FactoryPattern.Entityes;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory _EmployeeFactory = EmployeeFactory.GetEmployeeFactory();



            IEmployee Regular = _EmployeeFactory.GetEmployeeInstance("regular");
            IEmployee Consultant = _EmployeeFactory.GetEmployeeInstance("consultant");
            IEmployee Temporary = _EmployeeFactory.GetEmployeeInstance("tempoRary");
            IEmployee Intern = _EmployeeFactory.GetEmployeeInstance("intern");
            IEmployee XYZ = _EmployeeFactory.GetEmployeeInstance("xys");

        }
    }
}
