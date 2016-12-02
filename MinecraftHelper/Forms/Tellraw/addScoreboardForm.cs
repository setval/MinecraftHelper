using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinecraftHelper.Forms.Tellraw
{
    public partial class addScoreboardForm : Form
    {
        public addScoreboardForm()
        {
            InitializeComponent();
        }

        static addScoreboardForm MsgBox; public static DialogResult result = DialogResult.Abort;

        public void showAddScoreBoardForm(int code)
        {
            if (code == 1)
            {
                MsgBox = new addScoreboardForm();
                MsgBox.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) textBox1.Enabled = false;
            else textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "exit";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            TellrawScoreboardType tet = TellrawScoreboardType.NONE;
            switch (comboBox1.SelectedIndex)
            {
                case 0: tet = TellrawScoreboardType.NONE; break;
                case 1: tet = TellrawScoreboardType.DO_COMMAND; break;
                case 2: tet = TellrawScoreboardType.INVITE_COMMAND; break;
                case 3: tet = TellrawScoreboardType.OPEN_URL; break;
                case 4: tet = TellrawScoreboardType.CHANGE_PAGE; break;
            }
            if (textBox1.Text == "") textBox1.Text = " ";
            label1.Text = "returnexit";
        }

    }
}
