using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Pong
{
    public static class Global
    {
        public static GraphicsDevice GraphicsDevice;
        public static SpriteBatch spriteBatch;
        public static ContentManager contentManager;

        public static int screenHeight, screenWidth;
    }
}
