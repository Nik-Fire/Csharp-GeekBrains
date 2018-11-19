using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    static class Game
    {
        private static BufferedGraphicsContext context;
        public static BufferedGraphics Buffer;

        public static int Width { get; set; }
        public static int Height { get; set; }

        static Game()
        {

        }
        /// <summary>
        /// Вывод графики
        /// </summary>
        /// <param name="form">Используемая форма</param>
        public static void Init (Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            if (Width > 1000 || Width < 0 || Height > 1000 || Height < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();
            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        public static void Timer_Tick (object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);

            foreach (BaseObject obj in astro)
            {
                obj.Draw();
            }

            foreach (BaseObject obj in objs)
            {
                obj.Draw();
            }
            bullet.Draw();


            Buffer.Render();
        }

        public static void Update()
        {
            foreach (BaseObject obj in objs)
            {
                obj.Update();
            }
            bullet.Update();
            foreach (BaseObject obj in astro)
            {
                obj.Update();
                if (obj.Collision(bullet)) 
                {
                    System.Media.SystemSounds.Hand.Play();
                    obj.Respawn();
                    bullet.Respawn();
                }
            }
        }

        private static BaseObject[] objs;
        private static Asteroid[] astro;
        private static Bullet bullet;
        public static void Load()
        {
            Random rnd = new Random();
            objs = new BaseObject[31];
            astro = new Asteroid[5];
            bullet = new Bullet(new Point(150, Height / 2 - 15), new Point(5, 0), new Size(100, 40));
            for (int i = 0; i < astro.Length; i++)
            {
                int r = rnd.Next(20, 50);
                astro[i] = new Asteroid(new Point(Width, rnd.Next(0, Height)), new Point(-r / 5, r), new Size(r, r));
            }

            for (int i = 0; i < objs.Length; i++)
            {
                int r = rnd.Next(5, 50);
                objs[i] = new Star(new Point(1000, rnd.Next(0, Height)), new Point(r, r), new Size(3, 3));
                objs[30] = new Starship();
            }
        }
    }
}
