using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WelcomeFormApp;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new CommonForm());
        }
    }
}
