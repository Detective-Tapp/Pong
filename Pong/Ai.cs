using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class Ai : Unit
    {
        protected Vector2 min , max ;
        private bool flip = false;
        public Ai(Vector2 size) : base(new Vector2(0,0), size)
        {
            Box();
            tag = "Ai";
            min = new Vector2(Global.screenWidth -25, 10);
            max = new Vector2(Global.screenWidth -25, Global.screenHeight - size.Y - 10);
            pos = new Vector2(Global.screenWidth -25, (Global.screenHeight / 2) - size.Y);
        }
        public void Update()
        {/*
            if (pos.Y <= min.Y)
                flip = false;

            else if (pos.Y >= max.Y)
                flip = true;

            if (flip)
                pos.Y -= speed;
            else
                pos.Y += speed;
           */
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                pos.Y -= speed;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                pos.Y += speed;

            Sliding(min,max);
            base.Update();
        }
        public void Draw()
        {
            base.Draw();
        }
    }
}
