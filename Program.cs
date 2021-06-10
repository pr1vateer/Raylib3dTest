using System;
using System.Numerics;
using Raylib_cs;

namespace Raylib3dTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "3d test");

            var camera = GetCameraObject();

            var cubePosition = new Vector3(0.0f, 0.0f, 0.0f);
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.BeginMode3D(camera);
                Raylib.DrawCube(cubePosition, 2.0f, 2.0f, 2.0f, new Color(0,61,122,255));
                Raylib.DrawGrid(10, 1.0f);

                Raylib.EndMode3D();
                Raylib.DrawFPS(10,10);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        static Camera3D GetCameraObject()
        {
            Camera3D c = new Camera3D();

            c.position = new Vector3(0.0f, 10.0f, 10.0f);
            c.target = new Vector3(0.0f, 0.0f, 0.0f);
            c.up = new Vector3(0.0f, 1.0f, 0.0f);
            c.fovy = 45.0f;
            c.projection = CameraProjection.CAMERA_PERSPECTIVE;

            return c;
        }
    }
}
