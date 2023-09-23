using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Proyecto_Objetos
{
    public class Auto
    {


        private float x;
        private float y;
        private float z;
        private float size; // Tamaño del auto
        private float rotationAngle;

        public Auto(float x, float y, float z, float size)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.size = size;
            rotationAngle = 0.0f;
        }

       /* public void Dibujar() { 
               GL.PushMatrix();
            GL.Translate(x, y, z);
            GL.Rotate(rotationAngle, 0, -1, 0); // Rotar alrededor del eje X

        }*/

        public void Dibujar()
        {
            GL.PushMatrix();

            GL.Translate(x, y, z);
            GL.Rotate(rotationAngle, 0, -1, 0); // Rotar alrededor del eje Z
           
            /* GL.Scale(size, size, 1.0f); // Escalar el auto

             // Dibuja el cuerpo del auto (un rectángulo)
             GL.Color3(1.0, 0.0, 0.0); // Color rojo
             GL.Begin(PrimitiveType.Quads);
             GL.Vertex3(-0.5, -0.25,z);
             GL.Vertex3(0.5, -0.25,z);
             GL.Vertex3(0.5, 0.25,z);
             GL.Vertex3(-0.5, 0.25,z);
             GL.End();
            */

             // Dibuja las ruedas
             GL.Color3(0.0, 0.0, 0.0); // Color negro
             GL.PushMatrix();

             GL.Translate(-0.45, -0.25, z-1);
             GL.Scale(1, 1, 1.0); // Escalar la rueda
             
            DibujarCirculo(1.0);
            GL.PopMatrix();

            // GL.Color3(0.0, 0.0, 0.0); // Color negro
            GL.PushMatrix();

            GL.Translate(-0.45, -0.25, z + 1);
            GL.Scale(1, 1, 1.0); // Escalar la rueda

            DibujarCirculo(1.0);
            GL.PopMatrix();
            //
            GL.PushMatrix();
            GL.Translate(2, -0.25, z);
            GL.Scale(1, 1, 1.0); // Escalar la rueda
            DibujarCirculo(1.0);
            GL.PopMatrix();

            GL.PopMatrix();

            //rueda

        }

        public void Rotar(float deltaTime)
        {
            rotationAngle += 1.0f * deltaTime; // Rotación a 30 grados por segundo
        }

        private void DibujarCirculo(double radio)
        {
            int segments = 30; // Número de segmentos para aproximar el círculo

            GL.Begin(PrimitiveType.TriangleFan);

            // Dibujar el centro del círculo
            GL.Vertex2(0.0, 0.0);

            // Dibujar los vértices que forman el círculo
            for (int i = 0; i <= segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;
                double x = Math.Cos(angle) * radio;
                double y = Math.Sin(angle) * radio;
                GL.Vertex2(x, y);
            }

            GL.End();
        }
    }
}
