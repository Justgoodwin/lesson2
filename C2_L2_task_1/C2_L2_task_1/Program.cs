using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//
namespace C2_L2_task_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Random rnd = new Random();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Array workers = Array.CreateInstance(typeof(double), 10);

            TimeWorkers tmw = new TimeWorkers();
            FullTimeWorkers ftw = new FullTimeWorkers();
            Sorting srt = new Sorting();

            for (int i = 0; i < workers.Length; i++)
            {
                if (i%2==0)
                {
                    workers.SetValue(tmw.Parttimeworkers(rnd.Next(0, 50)), i);
                }
                else
                {
                    workers.SetValue(ftw.Fulltimeworkers(2000), i);
                }
            }

            foreach (var item in workers)
            {
                MessageBox.Show(item.ToString());
            }

            srt.Equals(workers);
        }
    }
}
