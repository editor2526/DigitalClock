using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockApp
{
    public partial class Form1 : Form
    {
        private Timer timer;    


        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer_Tick(sender, e, sizeof
        
        );
        }

        private void Timer_Tick(object sender, EventArgs e, int v)
        {
            // Get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            // Format the time string
            string time = $"{hh:D2}:{mm:D2}:{ss:D2}";

            // Update the label
            label1.Text = time;
            v
        }


    }
}
        
    

