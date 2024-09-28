using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface Isalary
    {
        public Double basesalary();
        public Double hrbasesalary();
       
    }

    interface Ivarablepay
    {
        public Double variavblesalary();  // Variable pay need only design class so i createsd on new interface and inhert permentemp class
    }

    public class permentEmployee : Isalary, Ivarablepay  //here achieved  SOLID Design pattan
    {
        public double basesalary()
        {
            return 12300.233;
        }

        public double hrbasesalary()
        {
            return 14300.233;
        }

        public double variavblesalary()
        {
            return 10300.233;
        }
    }

    public class ContractEmployee : Isalary
    {
        public double basesalary()
        {
            return 10000.233;
        }

        public double hrbasesalary()
        {
            return 10200.233;
        }

        //public double variavblesalary()  
        //{
        //    return 40200.233;
        //}
    }

}
