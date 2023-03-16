using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_digital_watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _Seconds = 0;
        private int _Minutes = 0;
        private int _Hours = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;
            if (_Seconds==60)
            {
                _Seconds = 0;
                _Minutes++;
                if (_Minutes==60)
                {
                    _Minutes = 0;
                    _Hours++;
                    if (_Hours==24)
                    {
                        _Hours = 0;
                    }
                }
            }
            labSeconds.Text = _Seconds.ToString();
            labMinutes.Text = _Minutes.ToString();
            labHours.Text = _Hours.ToString();
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            _Seconds = 0;
            _Minutes = 0;
            _Hours = 0;
            labSeconds.Text = _Seconds.ToString();
            labMinutes.Text = _Minutes.ToString();
            labHours.Text = _Hours.ToString();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
