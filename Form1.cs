using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelDockTest
{
    public partial class Form1 : Form
    { 
        Form Form2Effect = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            // for docking forms together more form needed
            //Form2.Show();
            //Second Form used for effect at docking
            
            
        }

        private void Form1_LocationChanged(object sender, EventArgs e) //bildschrimaufloesung einspeichern und location dafuer anpassen
        {
            Screen screen = Screen.PrimaryScreen; //Testimplementation von Screensize
            Rectangle rect = screen.Bounds;
            int screenWidth = rect.Width;
            int screenHeight = rect.Height;
            int screenTop = rect.Top;
            int screenLeft = rect.Left;

            label1.Text = "X Coodinates: "+this.Location.X.ToString();
            label2.Text = "Y Coodinates: " + this.Location.Y.ToString();

            ScreenXLabel.Text = "Screen Height: " + screenWidth.ToString();
            ScreenYLabel.Text = "Screen Width: " + screenHeight.ToString();

            if (this.Location.Y < 80 && this.Location.Y >0)
            {   
                Form2Effect.Location = new System.Drawing.Point(this.Location.X-20, this.Location.Y);
                Form2Effect.Size = new Size(500, 200);
                Form2Effect.TopMost = false;
                Form2Effect.Opacity = .100;
                Form2Effect.Show() ;
                //Form2Effect.Visible= true;
                

                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y-1);
                label2.Text = "Y Coodinates: "+this.Location.Y.ToString() + " Docking top";
                Thread.Sleep(50);
                if(this.Location.Y==0)
                {
                    Form2Effect.Visible = false;
                    Form2Effect.Close();
                }
            }
            if (this.Location.Y > 720 && this.Location.Y < 778) //ohne erkannte Bildschirmaufloesung muessen location Werte angepasst werden je nach Monitor
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y+1);
                label2.Text = "Y Coodinates: " + this.Location.Y.ToString() +" Docking bottom";
                Thread.Sleep(50);
            }
            if (this.Location.X < 80 && this.Location.X > 0)
            {
                this.Location = new System.Drawing.Point(this.Location.X-1, this.Location.Y);
                label1.Text = "X Coodinates: " + this.Location.X.ToString() + " <-- Docking left";
                Thread.Sleep(90);
            }
            if (this.Location.X > 1380 && this.Location.X < 1460)
            {
               
                this.Location = new System.Drawing.Point(this.Location.X+1, this.Location.Y);
                label1.Text = "X Coodinates: " + this.Location.X.ToString() + " Docking right -->";
                Thread.Sleep(50);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
