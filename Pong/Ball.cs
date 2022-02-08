using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class Ball : Unit
    {
        Random random;
        public Vector2 Direction;
        protected float ballSpeed;
        protected float ogSpeed;
        public Ball(Vector2 size, float speed) : base(new Vector2(0,0), size)
        {
            Box();
            tag = "Ball";
            pos = new Vector2((Global.screenWidth/2) - size.X, (Global.screenHeight/2) - size.Y);
            random = new Random();
            Direction = new Vector2((float)random.NextDouble(), (float)random.NextDouble()/2);
            ballSpeed = speed;
            ogSpeed = speed;
            parley = ballSpeed;
        }
        public int bounceScreen()
        {
            if (pos.Y <= 0)
                Direction.Y *= -1;
            if (pos.Y >= Global.screenHeight - size.Y)
                Direction.Y *= -1;

            if (pos.X <= 0)
            {
                pos = new Vector2((Global.screenWidth / 2) - size.X, (Global.screenHeight / 2) - size.Y);
                Direction = new Vector2((float)random.NextDouble(), (float)random.NextDouble()/2);
                parley = ogSpeed;
                return 1;
            } 
            if (pos.X >= Global.screenWidth - size.X)
            {
                pos = new Vector2((Global.screenWidth / 2) - size.X, (Global.screenHeight / 2) - size.Y);
                Direction = new Vector2((float)random.NextDouble(), (float)random.NextDouble()/2);
                parley = ogSpeed;
                return 2;
            }
            return 0;
        }
        
        public void Update()
        {
            Direction.Normalize();
            pos += Direction * ballSpeed;

            if (parley % 1 == 0)
                ballSpeed = parley;

            base.Update();  
        }
        public void Draw()
        {
            base.Draw();
        }
    }
}
