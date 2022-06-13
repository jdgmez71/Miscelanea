using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Datos
    {
        private int document;
        private string firstName;
        private string lastName;
        private double salary;
        private int daysWorked;    

        public Datos(int document, string firstName, string lastName, double salary, int daysWorked)
        {
            this.document = document;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.daysWorked = daysWorked;
        }

        public Datos()
        {

        }
        public void setDocument(int document)
        {
            this.document = document;
        }
        public int getDocument()
        {
            return document;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return lastName;
        }

        public void setSalary(double salary)
        {
            this.salary=salary;
        }
        public double getSalary()
        {
            return salary;
        }
        public void setDaysWorked(int daysworked)
        {
            this.daysWorked = daysworked;
        }
        public int getDaysWorked()
        {
            return daysWorked;
        }
        public Operation(double salarybase, double transportsubsidy, double healthcontributions, double aportesapensión, double fondodesolidaridadpensional, double cuotassindicales, double aportesacooperativas, double embargosjudiciales, double cuotasdecréditosaentidadesfinancieras)
        {
            salarybase = salary * daysWorked;
            Console.WriteLine("Salary Base is: " + salarybase);
            transportsubsidy = 117172;
            Console.WriteLine("Transport Subsidy: " + transportsubsidy);
            healthcontributions = (salary/30*100);
            Console.WriteLine("Health Constributions: " + healthcontributions);
        }


    }
}
