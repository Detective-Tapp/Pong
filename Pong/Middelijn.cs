using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Pong
{
    public class Middelijn : Unit
    {
        bool flip = false;
        Color clr;
        int slices;
        public Middelijn(Vector2 pos, Vector2 size, Color c, int slices) : base(pos,size)
        {
            this.slices = slices;
            clr = c;
            CreateTexture();
        }
        private void CreateTexture()
        {
            Color[] colors = new Color[(int)size.X * (int)size.Y];
            int count = 0;
            int spacing = Global.screenHeight - ((Global.screenHeight / 8) * 2) / slices;

            for (int i = 0; i < size.Y; i++)
            {               
                for (int j = 0; j < size.X; j++)
                {
                    if (i >= Global.screenHeight / 8 && i <= Global.screenHeight - (Global.screenHeight / 8))
                    {
                        if (flip)
                        {
                            colors[count] = clr;
                        }
                        else
                        {

                        }
                        if (count % spacing == 0)
                        {
                            FlipBool();
                        }
                         
                    }
                    count++;
                }
            }
            texture = new Texture2D(Global.GraphicsDevice, (int)size.X, (int)size.Y);
            texture.SetData(colors);
        }
        private void FlipBool()
        {
            if (flip)
                flip = false;
            else
                flip = true;
        }
        public void draw()
        {
            base.Draw();
        }
    }
}
