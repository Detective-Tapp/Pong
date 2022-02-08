using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class GameSpace
    {
        private SpriteFont font;

        private Player player;
        private Ai ai;
        private Ball ball;
        private Middelijn middelijn;

        Vector2 score;

        public GameSpace()
        {
            font = Global.contentManager.Load<SpriteFont>("File");
            score = new Vector2(0,0);

            player = new Player(new Vector2(16, 128));
            ai = new Ai(new Vector2(16, 128));
            ball = new Ball(new Vector2(32,32), 5);
            middelijn = new Middelijn(new Vector2(Global.screenWidth/2, 0), new Vector2(32,Global.screenHeight), Color.White, 8); 
        }

        public void Update()
        {
            player.Update();
            ai.Update();
            ball.Update();

            ball.Direction = ball.collision(player, ball);
            ball.Direction = ball.collision(ai, ball);

            int temp = ball.bounceScreen();
            if (temp == 1)
                score.Y++;
            else if (temp == 2)
                score.X++;
        }

        public void Draw()
        {
            player.Draw();
            ai.Draw();
            ball.Draw();
            middelijn.draw();
            Global.spriteBatch.DrawString(font, score.ToString(), new Vector2(Global.screenWidth / 2 - score.ToString().Length, 10 ), Color.White);
        }
    }
}
