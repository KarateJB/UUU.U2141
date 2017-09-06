using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U2141.Practice.UserInfo.Model;

namespace U2141.Practice.UserInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog().Equals(DialogResult.OK))
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = new User();
            user.Load();
            txtName.Text = user.Name;
            this.BackColor = user.BackColor;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var user = new User
            {
                Name = txtName.Text,
                BackColor = this.BackColor
            };

            user.Save();
        }
    }
}
