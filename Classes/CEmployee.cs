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
    public class CEmployee
    {
        //Fields
        private string id;
        private string surname;
        private string name;
        private DateTime dob;
        public static double tax;
        private string display;

        public CEmployee(string id, string surname, string name, DateTime dob)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.dob = dob;
            display = surname + ", " + name;
        }//constructor

        //Properties
        public string ID => id;
        public string Surname => surname;
        public string Name => name;
        public DateTime DOB => dob;

        public virtual double NetSalary()
        {
            throw new NotImplementedException();
        }//To be overriden in subclasses

        public string Display => display;
    }//class CEmployee
}//namespace
