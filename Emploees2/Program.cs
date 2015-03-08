using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emploees2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emploee> employees = new List<Emploee>();
            employees.Add(new Emploee(1, "Sasha", "Ivanov", 10));
            employees.Add(new Emploee(2, "Masha", "Petrova", 8));
            employees.Add(new Emploee(3, "Dasha", "Sidorova", 9));
            employees.Add(new Emploee(4, "Pasha", "Perov", 7));
            employees.Add(new Stavka (5, "Nyasha", "Poroh", 0));

            foreach (Emploee emp in employees)
            {
                emp.calc_salary();
            }

            foreach (Emploee emp in employees)
            {
                emp.printLine();
            }

        }

        
    }
}
