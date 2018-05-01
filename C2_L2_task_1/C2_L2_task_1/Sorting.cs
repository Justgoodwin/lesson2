using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_L2_task_1
{
    interface ICompare<T>
    {
        void Equals(T obj);
    }
    class Sorting : ICompare<Sorting>
    {
        public void Equals(Sorting obj) => Array.Sort(obj);
    }
}
