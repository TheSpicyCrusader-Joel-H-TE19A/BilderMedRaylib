using System;
using System.Numerics;
using Raylib_cs;

namespace BMR
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Most Epic Battles of Hisotry");

            Texture2D BBB = Raylib.LoadTexture("Bling-Bling_Boy.png");

            Texture2D Slayer = Raylib.LoadTexture("DoomSlayer.png");



            Random RecPosition = new Random();

            float Width = 1200;
            float Height = 800;
            float Speed = 0.5f;
            float x = 0;
            float y = 0;
            float Square1width = 100;
            float Square1height = 300;


            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && x < Width - 90)
                {
                    x += Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && x > 0)
                {
                    x -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && y > 0)
                {
                    y -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && y < Height - 112.5)
                {
                    y += Speed;
                }

                //

                if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Square1width < Width - 90)
                {
                    Square1width += Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Square1width > 0)
                {
                    Square1width -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Square1height > 0)
                {
                    Square1height -= Speed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Square1height < Height - 112.5)
                {
                    Square1height += Speed;
                }


                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.LIGHTGRAY);



                Raylib.DrawTextureEx(BBB, new Vector2(x, y), 0f, 0.25f, Color.WHITE);

                Raylib.DrawTextureEx(Slayer, new Vector2(Square1width, Square1height), 0f, 0.25f, Color.WHITE);



                Raylib.EndDrawing();
            }
        }
    }
}
