using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace NazmoxKeyPresser
{
    public partial class TimerUC : UserControl
    {
        public TimerUC()
        {
            InitializeComponent();
        }

        private void TimerUC_Load(object sender, EventArgs e)
        {
            TimerLabel.Text = "0 Milliseconds";
            numericUpDown1.Value = KeyPresser.MinTime;
            numericUpDown2.Value = KeyPresser.MaxTime;
            label13.Text = 0 + ". times";
        }

        public void CheckTickIntervalValue(Timer timer)
        {
            KeyPresser.MinTime = (int)numericUpDown1.Value;
            KeyPresser.MaxTime = (int)numericUpDown2.Value;
            ;
            KeyPresser.SetTimer();
            timer.Interval = KeyPresser.TickInterval;
            if (KeyPresser.TickInterval / 1000 >= 60)
            {
                TimerLabel.Text = ((double)((double)(KeyPresser.TickInterval / 1000) / 60)).ToString() + " minutes";
            }
            else
            {
                TimerLabel.Text = ((double)KeyPresser.TickInterval / 1000).ToString() + " seconds";
            }
        }

        private void setTimeIntervallButton_Click(object sender, EventArgs e)
        {

        }
    }
}
