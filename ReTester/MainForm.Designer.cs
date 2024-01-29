using OpenTK.Graphics;

namespace Template
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainViewport = new OpenTK.GLControl();
            this.btnChangeBack = new System.Windows.Forms.Button();
            this.chkAxesVisibility = new System.Windows.Forms.CheckBox();
            this.chkPolygonalStyle = new System.Windows.Forms.CheckBox();
            this.chkRotationOn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainViewport
            // 
            this.MainViewport.BackColor = System.Drawing.Color.Gray;
            this.MainViewport.Location = new System.Drawing.Point(1, 2);
            this.MainViewport.Margin = new System.Windows.Forms.Padding(5);
            this.MainViewport.Name = "MainViewport";
            this.MainViewport.Size = new System.Drawing.Size(1175, 768);
            this.MainViewport.TabIndex = 0;
            this.MainViewport.VSync = false;
            this.MainViewport.Load += new System.EventHandler(this.MainViewport_Load);
            this.MainViewport.Paint += new System.Windows.Forms.PaintEventHandler(this.MainViewport_Paint);
            this.MainViewport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainViewport_MouseMove);
            // 
            // btnChangeBack
            // 
            this.btnChangeBack.Location = new System.Drawing.Point(1200, 15);
            this.btnChangeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeBack.Name = "btnChangeBack";
            this.btnChangeBack.Size = new System.Drawing.Size(207, 28);
            this.btnChangeBack.TabIndex = 7;
            this.btnChangeBack.Text = "Change Background";
            this.btnChangeBack.UseVisualStyleBackColor = true;
            this.btnChangeBack.Click += new System.EventHandler(this.btnChangeBack_Click);
            // 
            // chkAxesVisibility
            // 
            this.chkAxesVisibility.AutoSize = true;
            this.chkAxesVisibility.Checked = true;
            this.chkAxesVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAxesVisibility.Location = new System.Drawing.Point(1200, 50);
            this.chkAxesVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.chkAxesVisibility.Name = "chkAxesVisibility";
            this.chkAxesVisibility.Size = new System.Drawing.Size(124, 20);
            this.chkAxesVisibility.TabIndex = 8;
            this.chkAxesVisibility.Text = "Axes are visible";
            this.chkAxesVisibility.UseVisualStyleBackColor = true;
            this.chkAxesVisibility.CheckedChanged += new System.EventHandler(this.chkAxesVisibility_CheckedChanged);
            // 
            // chkPolygonalStyle
            // 
            this.chkPolygonalStyle.AutoSize = true;
            this.chkPolygonalStyle.Location = new System.Drawing.Point(1199, 79);
            this.chkPolygonalStyle.Margin = new System.Windows.Forms.Padding(4);
            this.chkPolygonalStyle.Name = "chkPolygonalStyle";
            this.chkPolygonalStyle.Size = new System.Drawing.Size(123, 20);
            this.chkPolygonalStyle.TabIndex = 9;
            this.chkPolygonalStyle.Text = "Wireframe draw";
            this.chkPolygonalStyle.UseVisualStyleBackColor = true;
            this.chkPolygonalStyle.CheckedChanged += new System.EventHandler(this.chkPolygonalStyle_CheckedChanged);
            // 
            // chkRotationOn
            // 
            this.chkRotationOn.AutoSize = true;
            this.chkRotationOn.Location = new System.Drawing.Point(1200, 107);
            this.chkRotationOn.Margin = new System.Windows.Forms.Padding(4);
            this.chkRotationOn.Name = "chkRotationOn";
            this.chkRotationOn.Size = new System.Drawing.Size(90, 20);
            this.chkRotationOn.TabIndex = 10;
            this.chkRotationOn.Text = "Can rotate";
            this.chkRotationOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1196, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Press \'W\' to move up the cube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1196, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Press \'S\' to move down the cube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1196, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Press \'X\' to move the cube to the left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1196, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Press \'Z\' to move the cube to the right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1196, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Press \'D\' to move the cube forward";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1196, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Press \'A\' to move the cube backward";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 798);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRotationOn);
            this.Controls.Add(this.chkPolygonalStyle);
            this.Controls.Add(this.chkAxesVisibility);
            this.Controls.Add(this.btnChangeBack);
            this.Controls.Add(this.MainViewport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Laborator 11 - Stefanuca Monica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl MainViewport;
        private System.Windows.Forms.Button btnChangeBack;
        private System.Windows.Forms.CheckBox chkAxesVisibility;
        private System.Windows.Forms.CheckBox chkPolygonalStyle;
        private System.Windows.Forms.CheckBox chkRotationOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

