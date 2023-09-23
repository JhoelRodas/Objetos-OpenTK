using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Proyecto_Objetos
{
    /*Colores
     1.0f, 0.0f, 0.0f, 1.0f  rojo
    1.0f, 1.0f, 0.0f, 1.0f      amarillo
    1.0f, 0.5f, 0.0f, 1.0f      naranja
    0.5f, 0.0f, 1.0f, 1.0f      morado
    0.5f, 0.5f, 0.5f, 1.0f      gris
    1.0f, 0.5f, 0.5f, 1.0f      rosa
    0.5f, 1.0f, 0.0f, 1.0f      verde lima
    0.0f, 1.0f, 1.0f, 1.0f     cyan
    */

    public class Game:GameWindow
    {
        Pared pared;
        Pared repisa;
        Pared autop;
        Pared pared2;
        Pared repisa2;
        Pared autop2;
        Pared pared3;
        Pared repisa3;
        Pared autop3;
        Pared pared4;
        Pared repisa4;
        Pared autop4;
        Auto autito;
        public Game(int width, int heigth,string title):base(width,heigth,GraphicsMode.Default,title){ 
            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            pared.Rotar(1);
            repisa.Rotar(1);
            autop.Rotar(1);
            pared2.Rotar(2);
            repisa2.Rotar(2);
            autop2.Rotar(2);
            pared3.Rotar(1);
            repisa3.Rotar(1);
            autop3.Rotar(1);
            pared4.Rotar(1);
            repisa4.Rotar(1);
            autop4.Rotar(1);
             autito.Rotar(1);
            base.OnUpdateFrame(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            pared = new Pared(25, 25, 0, 8, 10, 3);  //lado superior derecho
            repisa = new Pared(25, 25,3 ,7, 1, 4);

            autito = new Auto(20, 22, 3 ,6);
            // autop = new Pared(25, 30, 4, 3, 2, 2);

            autop = new Pared(0, 0, 0, 3, 2, 2);

            pared2 = new Pared(-20, -20, 0, 8, 10, 3);  //lado inferirio izquierdo
            repisa2 = new Pared(-20, -20, 3, 7, 1, 4);
            autop2 = new Pared(-20, -15, 4, 3, 2, 2);

            pared3 = new Pared(-20, 20, 0, 8, 10, 3);   //lado superior izquierdo
            repisa3 = new Pared(-20, 20, 3, 7, 1, 4);
            autop3 = new Pared(-20, +25, 4, 3, 2, 2);


            pared4 = new Pared(20, -20, 0, 8, 10, 3);   //lado inferior derecho
            repisa4 = new Pared(20, -20, 3, 7, 1, 4);
            autop4 = new Pared(20, -15, 4, 3, 2, 2);
            base.OnLoad(e);

        }

        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            base.OnUnload(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            
            GL.ClearColor(0.6f, 0.3f, 1f, 1f);
           GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();

            repisa.Dibujar(1.0,0.0,0.0);//rojo
            pared.Dibujar(0.0,1.0,0.0);//azul
            autop.Dibujar(1.0,0.5,0.0);//naranja

            repisa2.Dibujar(0.0,0.0,1.0);//verde claro
            pared2.Dibujar(0.7f, 0.6f, 0.9f);//violeta
            autop2.Dibujar(1.0f, 0.0f, 0.0f);//rojo

            repisa3.Dibujar(0.7f, 0.9f, 0.9f);//celeste
            pared3.Dibujar(0.8f, 0.8f, 0.8f);//gris claro
            autop3.Dibujar(1.0f, 0.5f, 0.0f);//naranja

            repisa4.Dibujar(0.0f, 1.0f, 1.0f);//cyan
            pared4.Dibujar(0.5f, 0.9f, 0.8f);//turquesa pastel
            autop4.Dibujar(0.5f, 0.5f, 0.5f);//gris
            autito.Dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            float d = 50;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

    }
}
