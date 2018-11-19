using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    abstract class BaseObject : ICollision
    {
        protected Point pos;
        protected Point dir;
        protected Size size;
        
        protected BaseObject()
        {

        }

        protected BaseObject (Point pos, Point dir, Size size)
        {
            this.pos = pos;
            this.dir = dir;
            this.size = size;
        }

        public abstract void Draw();

        public abstract void Update();

        public Rectangle Rect
        {
            get
            {
                return new Rectangle(pos, size);
            }
        }

        public bool Collision(ICollision obj)
        {
            return obj.Rect.IntersectsWith(Rect);
        }

        public virtual void Respawn()
        {
            pos.X = 0;
        }
    }
}
