using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Collections.Generic;

namespace uni3
{
    public class Mundo 
    {

        readonly List<Ponto4D> listPoint = new List<Ponto4D>();
        Ponto4D ultimoPonto = null;

        public void OnMouseMove(Mouse e)
        {

        if(ultimoPonto != null){
            ultimoPonto.X = e.x;
            ultimoPonto.Y = e.y;
        }


        }

        public void OnMouseDown(Mouse e) //click mouse...
        {
            double x = e.x;
            double y = e.y;
            if (e.isLeft)
            {
                Ponto4D ponto = new Ponto4D(x, y);
                Ponto4D ponto2 = new Ponto4D(x, y);
                Console.WriteLine("esquerdo " + x + " - " + y);
                listPoint.Add(ponto);
                listPoint.Add(ponto2);

                ultimoPonto = ponto2;
            }
            else
            {
                Console.WriteLine("direito " + x + " - " + y);
            }
        }

        public void Draw()
        {

            Desenha.DesenhaPoligono(listPoint);

        }
    
    }

}