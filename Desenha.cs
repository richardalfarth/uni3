using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace uni3
{
    public class Desenha
    {
        public static void DesenhaPoligono(List<Ponto4D> list)
        {
            GL.LineWidth(2);
            GL.PointSize(5);
            GL.Color3(Color.Black);
            GL.Begin(PrimitiveType.LineLoop);
            list.ForEach(it => { GL.Vertex2(it.X, it.Y);});
            GL.End();
        }

        public  static void DesenhaPonto(Ponto4D p)
        {
            GL.LineWidth(3);
            GL.PointSize(3);
            GL.Color3(Color.Black);
            GL.Begin(PrimitiveType.LineLoop);
            GL.Vertex2(p.X, p.Y);
            GL.End();
        }
    }
}