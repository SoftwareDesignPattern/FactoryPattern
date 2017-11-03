using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Configurations
{
    public static class EnumEmployee
    {
        public enum EmployeeTypes
        {
            [Description("Regular")]
            Regular = 1,
            [Description("Consultant")]
            Consultant = 2,
            [Description("Temporary ")]
            Temporary = 3,
            [Description("Intern")]
            Intern = 4
        };
    }
}
