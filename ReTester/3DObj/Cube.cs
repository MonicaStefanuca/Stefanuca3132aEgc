using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template._3DObj
{

    class Cube
    {
        Coords v1, v2, v3, v4, v5, v6, v7, v8;
        Color color;
        PolygonMode currentPolygonState = PolygonMode.Fill;

        public Cube(Coords _v1, Coords _v2, Coords _v3, Coords _v4, Coords _v5, Coords _v6, Coords _v7, Coords _v8, Color _color)
        {
            v1 = _v1;
            v2 = _v2;
            v3 = _v3;
            v4 = _v4;
            v5 = _v5;
            v6 = _v6;
            v7 = _v7;
            v8 = _v8;
            color = _color;
        }
        public Cube(Color _color)
        {
            //creaaza un vector de string-uri cu fiecare coordonata din fisier
            String[] linie;
            //preluare fisier pentru prelucrare
            StreamReader r = new StreamReader("a.txt");
            linie = r.ReadLine().Split(' ');
            //preluare date si transformarea lor in intregi
            v1 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v2 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v3 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v4 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v5 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v6 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v7 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));
            linie = r.ReadLine().Split(' ');
            v8 = new Coords(int.Parse(linie[0]), int.Parse(linie[1]), int.Parse(linie[2]));

            color = _color;
        }

        public void PolygonDrawingStyle(String style)
        {
            if (style == "line")
            {
                currentPolygonState = PolygonMode.Line;
                return;
            }

            if (style == "surface")
            {
                currentPolygonState = PolygonMode.Fill;
                return;
            }

        }

        public void DrawMe()
        {
            GL.PolygonMode(MaterialFace.FrontAndBack, currentPolygonState);

            GL.Begin(PrimitiveType.Quads);

            int R = color.R;
            int G = color.G;
            int B = color.B;
            int offset = 20;

            GL.Color3(Color.FromArgb(R, G, B - offset));
            // baza
            GL.Vertex3(v1.x, v1.y, v1.z);
            GL.Vertex3(v2.x, v2.y, v2.z);
            GL.Vertex3(v3.x, v3.y, v3.z);
            GL.Vertex3(v4.x, v4.y, v4.z);

            GL.Color3(Color.FromArgb(R, G - offset, B));
            //perete dreapta
            GL.Vertex3(v2.x, v2.y, v2.z);
            GL.Vertex3(v3.x, v3.y, v3.z);
            GL.Vertex3(v7.x, v7.y, v7.z);
            GL.Vertex3(v6.x, v6.y, v6.z);

            GL.Color3(Color.FromArgb(R - offset, G, B));
            // perete fata
            GL.Vertex3(v3.x, v3.y, v3.z);
            GL.Vertex3(v4.x, v4.y, v4.z);
            GL.Vertex3(v8.x, v8.y, v8.z);
            GL.Vertex3(v7.x, v7.y, v7.z);

            GL.Color3(Color.FromArgb(R - offset, G, B - offset));
            // perete stanga
            GL.Vertex3(v1.x, v1.y, v1.z);
            GL.Vertex3(v4.x, v4.y, v4.z);
            GL.Vertex3(v8.x, v8.y, v8.z);
            GL.Vertex3(v5.x, v5.y, v5.z);

            GL.Color3(Color.FromArgb(R - offset, G - offset, B));
            // perete spate
            GL.Vertex3(v1.x, v1.y, v1.z);
            GL.Vertex3(v2.x, v2.y, v2.z);
            GL.Vertex3(v6.x, v6.y, v6.z);
            GL.Vertex3(v5.x, v5.y, v5.z);

            GL.Color3(Color.FromArgb(R - offset, G - offset, B - offset));
            // capac
            GL.Vertex3(v5.x, v5.y, v5.z);
            GL.Vertex3(v6.x, v6.y, v6.z);
            GL.Vertex3(v7.x, v7.y, v7.z);
            GL.Vertex3(v8.x, v8.y, v8.z);
            GL.End();
        }

        public void MoveUp(int distance)
        {
            UpdateCoordinates(0, distance, 0);
        }

        public void MoveDown(int distance)
        {
            UpdateCoordinates(0, -distance, 0);
        }

        public void MoveLeft(int distance)
        {
            UpdateCoordinates(-distance, 0, 0);
        }

        public void MoveRight(int distance)
        {
            UpdateCoordinates(distance, 0, 0);
        }

        public void MoveForward(int distance)
        {
            UpdateCoordinates(0, 0, distance);
        }

        public void MoveBackward(int distance)
        {
            UpdateCoordinates(0, 0, -distance);
        }

        private void UpdateCoordinates(int deltaX, int deltaY, int deltaZ)
        {
            v1.x += deltaX;
            v1.y += deltaY;
            v1.z += deltaZ;

            v2.x += deltaX;
            v2.y += deltaY;
            v2.z += deltaZ;

            v3.x += deltaX;
            v3.y += deltaY;
            v3.z += deltaZ;

            v4.x += deltaX;
            v4.y += deltaY;
            v4.z += deltaZ;

            v5.x += deltaX;
            v5.y += deltaY;
            v5.z += deltaZ;

            v6.x += deltaX;
            v6.y += deltaY;
            v6.z += deltaZ;

            v7.x += deltaX;
            v7.y += deltaY;
            v7.z += deltaZ;

            v8.x += deltaX;
            v8.y += deltaY;
            v8.z += deltaZ;
        }

        
    }
}
