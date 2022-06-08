using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carSimulation
{
    public partial class Form1 : Form
    {
        private Car myCar;

        public Form1()

        {
            InitializeComponent();
            myCar = new Car();

            myCar.SetBrand("Ferrari");

            myCar.SetMaxSpeed(240);
           
            lbInfo.Text = myCar.AsAString();

        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
             myCar.SpeedUp();
             lbInfo.Text = myCar.AsAString();

        }

        private void btnBreaks_Click(object sender, EventArgs e)
        {
            myCar.SlowDown();
            lbInfo.Text = myCar.AsAString();

        }
    }
}

