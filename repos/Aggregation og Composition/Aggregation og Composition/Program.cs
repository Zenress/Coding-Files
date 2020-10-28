using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation_og_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Department
    {
        /// <summary>
        /// Getter property der returnerer en liste af medarbejdere der ikke kan redigeres i
        /// </summary>
        public IReadOnlyList<Employee> Employees { get;}

        /// <summary>
        /// Getter og setter property der angiver om afdelingens budget er overskredet
        /// </summary>
        public bool IsBudgetExceeded { get; set; }

        /// <summary>
        /// Getter property der returner den månedlige udbetaling for alle medarbejdere
        /// </summary>
        public decimal MonthlyPayout { get;}

        /// <summary>
        /// Getter property der returnere den årlige udbetaling for alle medarbejdere
        /// </summary>
        public decimal YearlyPayout { get;}

        /// <summary>
        /// Getter og Setter property der angiver afdelingens årlige budget
        /// </summary>
        public decimal YearlyBudget { get; set; }
                
        private List<Employee> employees;
                
        private bool isBudgetExceeded;
                
        private decimal yearlyBudget;

        /// <summary>
        /// Tilføjer en ny medarbejder til af delingen
        /// </summary>
        /// <param name="employee"></param>
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
                
        public Department(List<Employee> employee, decimal yearlyBudget)
        {

        }

        /// <summary>
        /// Returnerer medarbejderen på baggrund af søgeparametre
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public Employee GetEmployeeBy(string ssn)
        {            
            return (Employee)Employees.Where(o => o.Ssn == ssn);
        }

        /// <summary>
        /// Returnerer medarbejderen på baggrund af søgeparametre
        /// </summary>
        /// <param name="firstnames"></param>
        /// <param name="lastnames"></param>
        /// <returns></returns>
        public Employee GetEmployeeBy(string firstnames, string lastnames)
        {
            return (Employee)Employees.Where(o => o.FirstName == firstnames);
        }

        /// <summary>
        /// Fjerner en medarbejder fra afdelingen
        /// </summary>
        /// <param name="employee"></param>
        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }

        /// <summary>
        /// Hjælpemetode, der returnerer en eventuel budgetoverskridelse
        /// </summary>
        private void CalculateBudgetExccession()
        {
            if (isBudgetExceeded == true)
            {
                yearlyBudget = YearlyBudget - YearlyPayout;
                Console.WriteLine(yearlyBudget);
            }            
        }

        /// <summary>
        /// Hjælpemetode til berigning af den månedlige udbetaling
        /// </summary>
        private void CalculateMonthlyPayout()
        {
            foreach (Employee employee in employees)
            {
                employee.GetMonthlyPayout();
            }
        }
    }

    public class Employee
    {
        public decimal ChristmasBonus { get; set; }
        public string FirstName { get; set; }
        public string LastNames { get; set; }
        public decimal MonthlyBaseSalary { get; set; }
        public decimal MonthlyBonusSalary { get; set; }
        public string Ssn { get; set; }

        /// <summary>
        /// Julebonus pr. år.
        /// </summary>
        private decimal christmasBonus;      
        
        private string firstname;        
        private string lastnames;

        /// <summary>
        /// Grundløn pr. måned
        /// </summary>
        private decimal monthlyBaseSalary;

        /// <summary>
        /// Løn ud over grundløn pr. måned
        /// </summary>
        private decimal monthlyBonusSalary;

        /// <summary>
        /// Skatteprocenten, såfremt årsløn er mindre end TopTaxLimit
        /// </summary>
        private const double NormalTaxRate = 0.37;

        /// <summary>
        /// Eng.: Social Security Number
        /// </summary>
        private string ssn;

        /// <summary>
        /// Afgør om skatteprocenten er normal eller høj (Top)
        /// </summary>
        private const decimal TopTaxLimit = 467300m;

        /// <summary>
        /// Beløb udover TopTaxLimit beskattes med denne skatteprocent
        /// </summary>
        private const double TopTaxRate = 0.15;
        public Employee(string firstname, string lastname, string ssn, decimal monthlyBaseSalary, decimal monthylBonusSalary, decimal christmasBonus)
        {
            
        }

        /// <summary>
        /// Returner den månedlige udbetalte løn
        /// </summary>
        /// <returns></returns>
        public decimal GetMonthlyPayout()
        {
            return (decimal)((double)monthlyBaseSalary + (double)monthlyBonusSalary * NormalTaxRate);
        }

        /// <summary>
        /// Returner den årlige løn
        /// </summary>
        /// <returns></returns>
        public decimal GetYearlyPayout()
        {
            return GetMonthlyPayout() * 12;
        }
    }
}
