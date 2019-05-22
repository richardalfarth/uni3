using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Collections.Generic;

namespace uni3
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Render window = new Render(600, 600);
            window.Run();
            window.Run(1.0 / 60.0);
        }
    }

}
