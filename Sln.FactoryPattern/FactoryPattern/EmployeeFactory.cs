using FactoryPattern.Entityes;
using System;
using static FactoryPattern.Configurations.EnumEmployee;

namespace FactoryPattern
{
    class EmployeeFactory
    {
        private static EmployeeFactory _EmployeeFactory = new EmployeeFactory();
        //Singleton here
        public static EmployeeFactory GetEmployeeFactory()
        {
            return _EmployeeFactory;
        }


        //Factory here
        public IEmployee GetEmployeeInstance(string objType)
        {

            if (objType.ToUpper() == EmployeeTypes.Regular.ToString().ToUpper())
            {
                return new RegularEmployee();
            }
            if (objType.ToUpper() == EmployeeTypes.Consultant.ToString().ToUpper())
            {
                return new Consultant();
            }
            if (objType.ToUpper() == EmployeeTypes.Temporary.ToString().ToUpper())
            {
                return new TemporaryEmployee();
            }
            if (objType.ToUpper() == EmployeeTypes.Intern.ToString().ToUpper())
            {
                return new Intern();
            }
            else
            {
                throw new ApplicationException("No such kind of employee exist");
            }
        }
    }
}
