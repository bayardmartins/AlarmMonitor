using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmMonitorApp
{
    public partial class FrmPanel : Form
    {
        
        public FrmPanel()
        {
            InitializeComponent();
        }

        public void writeInTextBox(string text)
        {
            this.textBox1.Text = text;
        }
    }
}
