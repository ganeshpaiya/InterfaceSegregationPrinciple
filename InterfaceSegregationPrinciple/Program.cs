using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            permentEmployee _pemp = new permentEmployee();
            Console.WriteLine("Salary Of Permand emp:" + (_pemp.basesalary() + _pemp.hrbasesalary() + _pemp.variavblesalary()));
            ContractEmployee _cemp = new ContractEmployee();
            Console.WriteLine("Salary Of Contract emp:" + (_pemp.basesalary() + _pemp.hrbasesalary()));//Here i dnt want Contract employee variable pay 
        }
    }
}
