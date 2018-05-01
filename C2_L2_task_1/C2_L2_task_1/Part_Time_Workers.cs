using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_L2_task_1
{
    class TimeWorkers:Workers
    {
        public override double Fulltimeworkers(double x)
        {
            return 0;
        }

        public override double Parttimeworkers(double time_fee)
        {
            double parttimeFee = 20.8 * 8 * time_fee;
            return parttimeFee;
        }
    }
}
