/*Lefaso Bongani Mabizela
 * 2016074458
 * CSIS 2614 Project1*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Classes
{
    [Serializable]
    class CSalEmployee : CEmployee
    {
        private double grossSalary;

        public CSalEmployee(string id, string surname, string name, DateTime dob, double grossSalary) : base(id, surname, name, dob)
        {
            this.grossSalary = grossSalary;
        }//constructor

        public override double NetSalary()
        {
            return grossSalary - (grossSalary * tax / 100);
            
        }//Overriding NetSalary Method from Parentclass(CEmployee)

        public override string ToString()
        {
            return string.Format("ID\t\t : {0}" + "\r\n" + "Surname\t\t : {1}" + "\r\n" + "Name\t\t : {2}" + "\r\n" 
                + "Date of Birth\t : {3} \r\nEmployee type\t : Salaried\r\nGross salary\t : {4}\r\nNet salary\t\t : {5}", base.ID, base.Surname, base.Name, base.DOB.ToShortDateString(), grossSalary, NetSalary());
        }//Overriding virtual ToString from Parent class(CEmployee)
    }//class SalariedEmployee
}//namespace
