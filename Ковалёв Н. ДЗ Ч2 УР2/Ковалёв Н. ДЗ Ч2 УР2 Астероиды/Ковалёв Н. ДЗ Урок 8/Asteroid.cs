using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    class Asteroid : BaseObject
    {
        public int Power { get; set; }

        public Asteroid (Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            Power = 1;
        }

        private Image Astro = Image.FromFile("Layered_Rock.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Astro, pos.X, pos.Y, size.Width, size.Height);
        }

        public override void Update()
        {
            pos.X = pos.X + dir.X;
            pos.Y = pos.Y + dir.Y;
            if (pos.X < 0) dir.X = -dir.X;
            if (pos.X > Game.Width) dir.X = -dir.X;
            if (pos.Y < 0) dir.Y = -dir.Y;
            if (pos.Y > Game.Height) dir.Y = -dir.Y;
        }

        public override void Respawn()
        {
            pos.X = Game.Width;
        }
    }
}
