using System;

namespace InterfacesReCapCalısma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoMethod();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
        }

        private static void DemoMethod()
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
        }
    }
}
