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

       

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2label1.Text = "X Coords: " + this.Location.X.ToString();
            Form2label2.Text = "Y Coords: "+this.Location.Y.ToString();

        }

    }
}
