using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace C2_lesson1
{
    class Star : BaseObject
    {
        public Star(Point pos, Point dir, Size size): base(pos, dir, size)
        {

        }
        public override void Draw()
        {
            Image img = Image.FromFile(@"index.png");
            Game.Buffer.Graphics.DrawImage(img, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawImage(img, Pos.X + Size.Width, Pos.X, Pos.Y, Pos.Y + Size.Height);

        }
        public override void Update()
        {
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
            Pos.X = Pos.X - Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
        }

    }
}
