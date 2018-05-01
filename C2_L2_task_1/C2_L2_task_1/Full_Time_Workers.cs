using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_L2_task_1
{
    class FullTimeWorkers:Workers
    {
        public override double Fulltimeworkers(double x)
        {
            double full_time_fee = x;
            return full_time_fee;
        }

        public override double Parttimeworkers(double time_fee)
        {
            return 0;
        }
    }
}
