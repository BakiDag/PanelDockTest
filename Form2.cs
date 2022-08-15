using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelDockTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_LocationChanged(object sender, EventArgs e)
        {   
            if (this.Location.Y < 30)
            {
                this.Location = new System.Drawing.Point(this.Location.X, 0);
            }
            if (this.Location.Y > 1000)
            {
                this.Location = new System.Drawing.Point(this.Location.X, 1025);
            }
            if (this.Location.X < 30)
            {
                this.Location = new System.Drawing.Point(0, this.Location.Y);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
