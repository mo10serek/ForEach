/*
* Created by: Michael
* Created on: 19-0ct-2015
* Created for: ICS3U
* Daily Assignment – Unit#3-12
* This programs shows 4 buttons that change all controls' color
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            foreach ( Control aControle in this.Controls)
            {
                aControle.BackColor = Color.Red;
            }
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            foreach (Control aControle in this.Controls)
            {
                aControle.BackColor = Color.WhiteSmoke;
            }
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            foreach (Control aControle in this.Controls)
            {
                aControle.BackColor = Color.Turquoise;
            }
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            foreach (Control aControle in this.Controls)
            {
                aControle.BackColor = Color.YellowGreen;
            }
        }
    }
}
