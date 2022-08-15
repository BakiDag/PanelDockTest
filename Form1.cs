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
        public Form1()
        {
            InitializeComponent();
            //Form Form2 = new Form2(); // for docking forms together second form needed
            //Form2.Show();
            
        }

        private void Form1_LocationChanged(object sender, EventArgs e) //bildschrimaufloesung einspeichern und location dafuer anpassen
        {

            label1.Text = "X Coodinates: "+this.Location.X.ToString();
            label2.Text = "Y Coodinates: " + this.Location.Y.ToString();
            if (this.Location.Y < 40  )
            {                
                this.Location = new System.Drawing.Point(this.Location.X, 0);
                label2.Text = "Docking top";
            }
            if (this.Location.Y> 740) //ohne erkannte Bildschirmaufloesung muessen location Werte angepasst werden je nach Monitor
            {                
                this.Location = new System.Drawing.Point(this.Location.X, 818);
                label2.Text = "Docking bottom";
            }
            if (this.Location.X < 30)
            {  
                this.Location = new System.Drawing.Point(0,this.Location.Y );
                label1.Text = "<-- Docking left";
            }
            if (this.Location.X < 40)
            {
                this.Location = new System.Drawing.Point(0, this.Location.Y);
                label1.Text = "<-- Docking left";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
