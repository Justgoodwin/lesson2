using System;
using System.Drawing;
using System.Windows.Forms;

namespace C2_lesson1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form form = new Form()
            {
                Width = Screen.PrimaryScreen.Bounds.Width,
                Height = Screen.PrimaryScreen.Bounds.Height
            };
            form.Width = 800;
            form.Height = 600;
            Game.Init(form);
            form.Show();
            Game.Load();
            Game.Draw();
            Application.Run(form);

        }
    }
}
