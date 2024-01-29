using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Template._3DObj;

namespace Template
{
    public partial class MainForm : Form
    {
        float camDepth;
        private bool isScaling = false;

        int eyePosX, eyePosY, eyePosZ;
        private Point mousePos;

        Color backColor = Color.Gray;
        Random rnd = new Random();

        Coords v1 = new Coords(10, 0, 10);
        Coords v2 = new Coords(40, 0, 10);
        Coords v3 = new Coords(40, 0, 40);
        Coords v4 = new Coords(10, 0, 40);
        Coords v5 = new Coords(10, 30, 10);
        Coords v6 = new Coords(40, 30, 10);
        Coords v7 = new Coords(40, 30, 40);
        Coords v8 = new Coords(10, 30, 40);

        Axes mainAx;
        Cube cb;
        Vector4 positionv = new Vector4(13.0f,13.0f,13.0f,0.1f);
        
        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
            this.KeyPreview = true;
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupDefaultValues();
            SetupWindowGUI();
            SetupSceneObjects();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"Key pressed: {e.KeyCode}");
                switch (e.KeyCode)
                {
                    case Keys.W:
                        cb.MoveUp(5);
                        break;
                    case Keys.S:
                        cb.MoveDown(5);
                        break;
                    case Keys.A:
                        cb.MoveLeft(5);
                        break;
                    case Keys.D:
                        cb.MoveRight(5);
                        break;
                    case Keys.X:
                        cb.MoveForward(5);
                        break;
                    case Keys.Z:
                        cb.MoveBackward(5);
                        break;
                    default:
                        break;
                }
            

            MainViewport.Invalidate();
        }
       

        private void SetupDefaultValues()
        {
            camDepth = 1.04f;
            eyePosX = 100;
            eyePosY = 100;
            eyePosZ = 50;
        }

        private void SetupWindowGUI()
        {

        }

        private void SetupSceneObjects()
        {
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Enable(EnableCap.Texture2D);

            mainAx = new Axes(chkAxesVisibility.Checked);
            //cb = new Cube(v1, v2, v3, v4, v5, v6, v7, v8, Color.LightBlue);

            ////constructor pentru citire coordonate din fisier
            cb = new Cube(Color.LightBlue);
        }

        private void MainViewport_Load(object sender, EventArgs e)
        {
            GL.ClearColor(backColor);
        }

        private void chkAxesVisibility_CheckedChanged(object sender, EventArgs e)
        {
            mainAx.SetVisibility(chkAxesVisibility.Checked);
            MainViewport.Invalidate();
        }

        private void chkPolygonalStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPolygonalStyle.Checked == true)
            {
                cb.PolygonDrawingStyle("line");
            } else
            {
                cb.PolygonDrawingStyle("surface");
            }
            MainViewport.Invalidate();
        }

        private void btnChangeBack_Click(object sender, EventArgs e)
        {
            backColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            MainViewport.Invalidate();
        }

        private void MainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = new Point(e.X, e.Y);
            MainViewport.Invalidate();
        }
        
        

        
       

        private void MainViewport_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);
            GL.ClearColor(backColor);

            SetView();

            if (chkRotationOn.Checked == true)
            {
                // Doar după Ox.
                GL.Rotate(Math.Max(mousePos.X, mousePos.Y), 1, 1, 1);
            }

            // GRAPHICS PAYLOAD
            mainAx.DrawMe();
            cb.DrawMe();
          
            // citirea datelor din fisier este realizata in constructotul cube(culoare)
            //cin lasa cube
            MainViewport.SwapBuffers();
        }

        private void SetView() {
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(camDepth, 4 / 3, 1, 256);    
            Matrix4 lookat = Matrix4.LookAt(eyePosX, eyePosY, eyePosZ, 0, 0, 0, 0, 1, 0);                   
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);                                                             
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, MainViewport.Width, MainViewport.Height);                                        
        }

    }
}
