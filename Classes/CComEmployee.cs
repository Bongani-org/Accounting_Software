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
    class CComEmployee : CEmployee
    {
        //fields
        private double monthlySales;
        public static double commission;

        public CComEmployee(string id, string surname, string name, DateTime dob, double monthlySales) : base(id, surname, name, dob)
        {
            this.monthlySales = monthlySales;
        }//constructor

        public double MonthlySales => monthlySales;

        public override double NetSalary()
        {
            var c = monthlySales * commission / 100;
            return c - (c * tax / 100);    
        }//Overriding NetSalary Method in Parent class(CEmployee)

        public override string ToString()
        {
            //return string.Format("ID {0}\nSurname\t {1}\nName\t {2}\nDate of Birth\t {3}", base.ID, base.Surname, base.Name, base.DOB.ToShortDateString());
            return string.Format("ID\t\t : {0}" + "\r\n" + "Surname\t\t : {1}" + "\r\n" + "Name\t\t : {2}" + "\r\n"
                + "Date of Birth\t : {3} \r\nEmployee type\t : Commissioned\r\nMonthly sales\t : {4}\r\nNet salary\t\t : {5}", base.ID, base.Surname, base.Name, base.DOB.ToShortDateString(), monthlySales, NetSalary());
        }//overriding virtual ToString Method of Parent(CEmployee)
    }//classCommisionedEmployees
}//namespace
