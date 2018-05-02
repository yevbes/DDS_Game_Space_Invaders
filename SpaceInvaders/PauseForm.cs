using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public PauseForm(string msg, string buttonText1)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            labelMsgPause.Text = msg.ToString();
            buttonPauseResume.Text = buttonText1.ToString();
        }

        
        private void buttonPauseResume_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
