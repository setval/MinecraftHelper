using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MinecraftHelper.Forms.Tellraw
{
    public partial class addScoreboard : Form
    {
        public addScoreboard(string name, List<string> list)
        {
            InitializeComponent();
            this.Text = this.Text + name;
            foreach (string s in list)
                comboBox1.Items.Add(s);
        }

        public DialogResult dr = DialogResult.Cancel;

        private void btn_addSc_Click(object sender, EventArgs e)
        {
            dr = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == -1) textBox1.Enabled = false;
            else textBox1.Enabled = true;
        }
    }
}
