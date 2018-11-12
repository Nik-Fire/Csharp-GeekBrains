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
            foreach (BaseObject obj in objs)
            {
                obj.Draw();
            }
            Buffer.Render();
        }

        public static void Update()
        {
            foreach (BaseObject obj in objs)
            {
                obj.Update();
            }
        }

        public static BaseObject[] objs;
        public static void Load()
        {
            Random r = new Random();
            objs = new BaseObject[32];
            for (int i = 0; i < objs.Length / 2; i++)
            {
                objs[i] = new BaseObject(new Point(600, i * 20), new Point(-i - 5, -i - 5), new Size(50, 50));
            }

            for (int i = objs.Length / 2; i < objs.Length; i++)
            {
                objs[i] = new Star(new Point(600, r.Next(-Height, Height)), new Point(i, 0), new Size(5, 5));
                objs[31] = new Starship();
            }
        }
    }
}
