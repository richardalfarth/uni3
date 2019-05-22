using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Collections.Generic;

namespace uni3
{
    public class Poligono
    {
        readonly List<Ponto4D> pontos = new List<Ponto4D>();
        readonly BBox bbox = new BBox();
        PrimitiveType primTipo = PrimitiveType.LineLoop;
        Ponto4D ultimoPonto;

        /*public Poligono(List<Ponto4D> listPontos)
        {
            AddPontos(listPontos);
        }

        private void AddPontos(List<Ponto4D> listPontos)
        {
            listPontos.ForEach(it => { pontos.Add(it); bbox.atualizarBBox(it);});
        }

        
        public static void Desenhar()
        {
            GL.LineWidth(2);
            GL.PointSize(5);
            GL.Color3(Color.Black);
            GL.Begin(primitiveType);
            pontos.ForEach(it => { GL.Vertex2(it.X, it.Y);});
            GL.End();
        }

        public static void DesenhaPonto()
        {
            GL.LineWidth(2);
            GL.PointSize(5);
            GL.Color3(Color.Black);
            GL.Begin(PrimitiveType.Points);
            GL.Vertex2(ponto.X, ponto.Y);
            GL.End();
        }*/
    }
}