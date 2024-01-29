using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;
using Template._3DObj;
namespace Template._3DObj
{
    class MyPoint
    {
        float x, y, z;
        Color c;
        //variabila pentru schimbare vizibilitatii punctului
        bool visibility {get; set ;}
        public MyPoint()
        {
            x = y = z = 0;
            c = Color.Red;
        }
        //schimbare vizibilitate punct, utilizata in chackbuton
        public void Toggle()
        {
            if (visibility == true)
                visibility =false;
            else
                visibility = true;
        }

        public void  DrowMe(float _x, float _y, float _z)
        {
            //daca obiectul nu e vizibil acesta nu se va desena
            if (visibility == false)
                return;
            //doar daca obiectul e vizibil acesta se deseneaza
            //coordonate ale luminii transmide ca parametru
            x = _x;
            y = _y;
            z = _z;
            //setare dimensiune punct
            GL.PointSize(5);
            //desenare punct
            GL.Begin(PrimitiveType.Points);
            GL.Vertex3(x,y,z);
            GL.End();

        }
    }
    
}
