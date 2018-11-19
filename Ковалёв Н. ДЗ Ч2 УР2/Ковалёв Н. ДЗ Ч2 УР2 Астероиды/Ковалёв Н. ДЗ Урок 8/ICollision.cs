using System;
using System.Drawing;

namespace Ковалёв_Н.ДЗ_Урок_8
{
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}
