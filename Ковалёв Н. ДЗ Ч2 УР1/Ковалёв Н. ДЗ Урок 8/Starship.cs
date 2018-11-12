using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    class Starship : BaseObject
    {
        bool flag = true;
        int count = 0;
        public Starship ()
        {
            pos.X = 10;
            pos.Y = Game.Height / 2 -50;
            size.Width = 200;
            size.Height = 100;
        }

        private Image Ship = Image.FromFile("Spaceship.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Ship, pos.X, pos.Y, size.Width, size.Height);
        }

        public override void Update()
        {
            if (count == 5) flag = false;
            if (count == -1) flag = true;

            if (flag)
            {
                pos.Y += 5;
                count++;
            }
            else
            {
                pos.Y -= 5;
                count--;
            }
        }
    }
}
