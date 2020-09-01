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
            panelSeals.Location = new Point(0,31);
            panelReport.Location = new Point(0, 31);
            ClientSize = new Size(450, 250);
            panelData.Visible = false;
            panelReport.Visible = false;


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

        private void CheckBoxId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxId.Checked)
            {
                textBoxId.Visible = true;
            }
            else
            {
                textBoxId.Visible = false;
            }
        }

        private void CheckBoxSPlace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSPlace.Checked)
            {
                textBoxSPlace.Visible = true;
            }
            else
            {
                textBoxSPlace.Visible = false;
            }
        }

        private void CheckBoxSNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSNumber.Checked)
            {
                textBoxSNumber.Visible = true;
            }
            else
            {
                textBoxSNumber.Visible = false;
            }
        }

        private void CheckBoxSTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSTime.Checked)
            {
                textBoxSTime.Visible = true;
            }
            else
            {
                textBoxSTime.Visible = false;
            }

        }

        private void CheckBoxSMan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSMan.Checked)
            {
                textBoxSMan.Visible = true;
            }
            else
            {
                textBoxSMan.Visible = false;
            }
        }

        private void ФормуванняЗвітівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            panelSeals.Visible = false;
            формуванняЗвітівToolStripMenuItem.Checked = true;
            основніДіїЗПломбамиToolStripMenuItem.Checked = false;
        }

        private void ОсновніДіїЗПломбамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelReport.Visible = false;
            panelSeals.Visible = true;
            формуванняЗвітівToolStripMenuItem.Checked = false;
            основніДіїЗПломбамиToolStripMenuItem.Checked = true;
        }

        private void CheckedListBoxReports_ItemCheck(object sender, ItemCheckEventArgs e)  // Leaves only one item checked
        {
            for (int ix = 0; ix < checkedListBoxReports.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxReports.SetItemChecked(ix, false);
        }

        private void CheckedListBoxSeals_ItemCheck(object sender, ItemCheckEventArgs e)  // Leaves only one item checked
        {
            for (int ix = 0; ix < checkedListBoxSeals.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxSeals.SetItemChecked(ix, false);
        }

        private void CheckBoxDiapazon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiapazon.Checked)
            {
                textBoxDiap2.Visible = true;
            }
            else
            {
                textBoxDiap2.Visible = false;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            panelSeals.Visible = true;
            panelData.Visible = false;
            ClientSize = new Size(450, 250);
        }

        private void ButtonRepport_Click(object sender, EventArgs e)
        {
            panelData.Visible = true;
            panelData.Location = new Point(0, 31);
            ClientSize = new Size(1130, 450);
        }
    }
}
