using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    class Bullet : BaseObject
    {
        public Bullet (Point pos, Point dir, Size size) : base(pos, dir, size)
        {

        }

        private Image Missile = Image.FromFile("Missile.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Missile, pos.X, pos.Y, size.Width, size.Height);
        }

        public override void Update()
        {
            pos.X += 5;
        }

        public override void Respawn()
        {
            pos.X = 150;
        }
    }
}
