using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Collections.Generic;

namespace uni3
{
    public class Render : GameWindow
    {
        Mundo mundo = new Mundo();
        Camera camera = null;

        Desenha desenha = new Desenha();

        bool mouse = true;
        public Render(int width, int height) : base(width, height) {
            camera = Camera.Instance(-width, width, -height, height);
         }

        public int X { get; set; }
        public int Y { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, camera.xmax, 0, camera.ymax, -1, 1);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.White);
            GL.MatrixMode(MatrixMode.Modelview);

            mundo.Draw();
            
            this.SwapBuffers();
        }

        protected override void OnKeyDown(OpenTK.Input.KeyboardKeyEventArgs e) //Parte das teclas....
        {
            if (e.Key == Key.Space)
            {
                Console.WriteLine("espaço");
            }
            if (e.Key == Key.Delete)
            {
                Console.WriteLine("delete");
            }
            if (e.Key == Key.P)
            {
                Console.WriteLine("p");
            }
            if (e.Key == Key.R)
            {
                Console.WriteLine("r");
            }
            if (e.Key == Key.G)
            {
                Console.WriteLine("g");
            }
            if (e.Key == Key.B)
            {
                Console.WriteLine("b");
            }
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            base.OnMouseMove(e);
            mundo.OnMouseMove(new Mouse(e));
        }

        protected override void OnMouseDown(MouseButtonEventArgs e) //click mouse...
        {
            base.OnMouseDown(e);
            mundo.OnMouseDown(new Mouse(e));
        }
    }
}