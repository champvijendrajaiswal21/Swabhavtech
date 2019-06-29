using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class CommonForm : Form
    {
        public CommonForm()
        {
        Button red = new Button();
        Button blue = new Button();
            red.Text = "red";
            red.Height = 40;
            red.Width = 40;
            red.Location = new System.Drawing.Point(20, 50);
            blue.Text = "blue";
            blue.Height = 40;
            blue.Width = 40;
            blue.Location = new System.Drawing.Point(20, 90);
            this.BackColor = System.Drawing.Color.CadetBlue;
            red.Click += backgroundchange;
            blue.Click += backgroundchange;
            this.Controls.Add(red);
            this.Controls.Add(blue);


        }
         void backgroundchange(object obj, EventArgs args)
        {
           
            Button button = (Button)obj;
            if(button.Text=="red")
            {
               BackColor = System.Drawing.Color.Red;
            }
            if (button.Text == "blue")
            {
                BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
