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
            myCar.SetMaxSpeed(100);

            // myCar.setMaxSpeed(240);
            // lbInfo.Text = "Speed of my " + myCar.Brand+ " is " + myCar.CurrentSpeed +  " km/h and it's maximum speed is " + myCar.MaximumSpeed + " km/h" ;
            //lbInfo.Text = ($"Speed of my  {myCar.Brand}  is  {myCar.CurrentSpeed}  km/h and it's maximum speed is  {myCar.MaximumSpeed}  km/h");
            lbInfo.Text = ($"Speed of my  {myCar.AsAString()}  is  {myCar.CurrentSpeed}  km/h and it's maximum speed is  {Convert.ToString (myCar.SetMaxSpeed())}  km/h");
               



        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            myCar.SpeedUp();
        }
    }
}

