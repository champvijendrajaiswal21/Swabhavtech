using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WelcomeFormApp
{
   
    class WindowsForm : Form
    {
       public WindowsForm()
        {
            this.Text = "akash";
            this.Width = 1024;
            this.Height = 786;
            this.BackColor = System.Drawing.Color.CadetBlue;
            Button button = new Button();
            button.Text = "just";
            button.Location = new System.Drawing.Point(50,50);
            button.Click += HelloHandler;
            button.Click += GoodbyeHelloHandler;

           
            this.Controls.Add(button);
        }
        static void HelloHandler(object obj, EventArgs args)
        {
            Console.WriteLine("hello");
        }
        static void GoodbyeHelloHandler(object obj, EventArgs args)
        {
            Console.WriteLine("goodbye");
        }
    }
}
