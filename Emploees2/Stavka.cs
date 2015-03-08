using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emploees2
{
    class Stavka: Emploee
    {
        public Stavka(int number, string name, string last_name, int work_hours)
            : base(number, name, last_name, work_hours)
        { 
        
        }

        public override void calc_salary()
        {
           // base.calc_salary();

            salary = 1000;
        } 

    }
}
