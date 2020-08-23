using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace win_shutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t " +
                Convert.ToInt32(timePicker.Value.Subtract(DateTime.Now).TotalSeconds).ToString() );
            psi.CreateNoWindow = false;
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void button_abort_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/a");
            psi.CreateNoWindow = false;
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }
}
