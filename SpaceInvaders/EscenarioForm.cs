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
    public partial class EscenarioForm : Form
    {
        private Form form;
        public EscenarioForm(Form form)
        {
            this.form = form;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void EscenarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to really exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                form.Show();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void EscenarioForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p')
            {
                PauseForm pauseForm = new PauseForm("The game is paused, press resume to continue", "Resume");
                pauseForm.ShowDialog();
            }
        }
    }
}
