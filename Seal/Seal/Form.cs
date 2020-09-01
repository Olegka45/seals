using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        

        private void CheckBoxPlace_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPlace.Checked)
            {
                textBoxPlace.Visible = true;
            }
            else
            {
                textBoxPlace.Visible = false;
            }
        }

        private void CheckBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
            {
                textBoxTime.Visible = true;
            }
            else
            {
                textBoxTime.Visible = false;
            }
        }

        private void CheckBoxNumber_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNumber.Checked)
            {
                textBoxNumber.Visible = true;
            }
            else
            {
                textBoxNumber.Visible = false;
            }
        }
    }
}
