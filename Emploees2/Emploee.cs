using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emploees2
{
    class Emploee
    {
        int number;
        string name;
        string last_name;
        int work_hours;
        protected int salary;

        public Emploee(int number, string name, string last_name, int work_hours)
        { 
            this.number = number;
            this.name = name;
            this.last_name = last_name;
            this.work_hours = work_hours;
            
        }

       

        public void printLine()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} |", number,
                (name + " " + last_name).PadLeft(15), work_hours, salary);

        }

        public virtual void calc_salary()
        {
            salary = work_hours * 10;
        }




    }
}
