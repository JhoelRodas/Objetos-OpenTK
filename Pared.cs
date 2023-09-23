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
    public class Pared
    {
        private float ancho;
        private float alto;
        private float profundidad;
        private float x;
        private float  y;
        private float  z;
        private float rotationAngle;


        public Pared(int x, int y, int z, float ancho, float alto, float profundidad) { 
            this.ancho = ancho;
            this.alto = alto; 
            this.profundidad = profundidad;
            this.x = x;
            this.y = y;
            this.z = z;
            rotationAngle = 0.0f;
        }

        public void Dibujar(double r,double g,double b)
        {
            GL.PushMatrix(); // Save the current matrix
                             //  GL.Rotate(rotationAngle, 0, -1, 0.1);

            GL.Translate(x, y, z);
            GL.Rotate(rotationAngle, 0, -1, 0); // Rotar alrededor del eje X
            GL.Translate(-x, -y, z);

            PrimitiveType primitiveType = PrimitiveType.Quads;
            GL.Color3(r, g, b);
            izq(primitiveType);
            atras(primitiveType);
            adelante(primitiveType);
            der(primitiveType);
            abajo(primitiveType);
           arriba(primitiveType);

            GL.PopMatrix();

        }
        public void Rotar(float deltaTime)
        {
            rotationAngle += 1.0f * deltaTime;
        }

        private void atras(PrimitiveType primitiveType) {
            GL.Begin(primitiveType);
            // GL.Color3(1.0, 0.0, 0.0);//rojo           
            GL.Vertex3(x - ancho, y + alto, z - profundidad);
             GL.Vertex3(x + ancho, y + alto, z - profundidad);
             GL.Vertex3(x + ancho, y - alto, z - profundidad);
             GL.Vertex3(x - ancho, y - alto, z - profundidad);
            GL.End();
        }
        private void adelante(PrimitiveType primitiveType) {

            GL.Begin(primitiveType);

           // GL.Color3(1.0, 1.0, 0.0);//amarillo
            GL.Vertex3(x - ancho, y + alto, z + profundidad);
            GL.Vertex3(x + ancho, y + alto, z + profundidad);
            GL.Vertex3(x + ancho, y - alto, z + profundidad);
            GL.Vertex3(x - ancho, y - alto, z + profundidad);
            GL.End();
        }
        private void izq(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
           // GL.Color3(0.0, 1.0, 0.0);//verde
            GL.Vertex3(x - ancho, y + alto, z - profundidad);
            GL.Vertex3(x - ancho, y + alto, z + profundidad);
            GL.Vertex3(x - ancho, y - alto, z + profundidad);
            GL.Vertex3(x - ancho, y - alto, z - profundidad);
            GL.End();
        }

        private void der(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
          
            GL.Vertex3(x + ancho, y + alto, z - profundidad);
            GL.Vertex3(x + ancho, y + alto, z + profundidad);
            GL.Vertex3(x + ancho, y - alto, z + profundidad);
            GL.Vertex3(x + ancho, y - alto, z - profundidad);
            GL.End();
        }

        private void abajo(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
         
            GL.Vertex3(x - ancho, y - alto, z - profundidad);
            GL.Vertex3(x + ancho, y - alto, z - profundidad);
            GL.Vertex3(x + ancho, y - alto, z + profundidad);
            GL.Vertex3(x - ancho, y - alto, z + profundidad);
            GL.End();
        }

        private void arriba(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
           // GL.Color3(0, 1, 1.3);//azul;
            GL.Vertex3(x - ancho, y + alto, z - profundidad);
            GL.Vertex3(x + ancho, y + alto, z - profundidad);
            GL.Vertex3(x + ancho, y + alto, z + profundidad);
            GL.Vertex3(x - ancho, y + alto, z + profundidad);
            GL.End();
        }


    }
}
