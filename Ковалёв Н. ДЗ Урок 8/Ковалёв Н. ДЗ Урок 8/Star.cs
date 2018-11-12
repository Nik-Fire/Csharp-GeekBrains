using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    class Star : BaseObject
    {
        Random r = new Random();

        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.White, pos.X, pos.Y, pos.X + size.Width, pos.Y + size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.White, pos.X + size.Width, pos.Y, pos.X, pos.Y + size.Height);
        }

        public override void Update()
        {
            pos.X = pos.X - dir.X;
            if (pos.X < 0)
            {
                pos.X = Game.Width + size.Width;
                pos.Y = pos.Y + r.Next(-5, 6);
            }
        }
    }
}
