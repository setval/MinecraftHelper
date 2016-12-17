using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MinecraftHelper.Forms.Tellraw
{
    public partial class addScoreboard : Form
    {
        private const int SIZE_1 = 116;
        private const int SIZE_2 = 219;
        private const int SPEED = 16;

        private bool isName = false;

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
            if (!(textBox1.Text == "" && textBox1.Enabled == true))
            {
                dr = DialogResult.OK;
                this.Close();
            }
            else this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == -1 || (this.Text == "Добавить событие при наведении" && comboBox1.SelectedIndex == 3)) textBox1.MaxLength = 0;
            else { textBox1.MaxLength = 24999; textBox1.Text = ""; }
            

            if (comboBox1.SelectedIndex == 3 && this.Text == "Добавить событие при наведении") { isName = true; update.Start(); label1.Visible = true; }
            else { isName = false; label1.Visible = false; update.Start(); }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (isName == true && this.Height < SIZE_2)
            {
                this.Height += SPEED;
            }
            else if (isName == false && this.Height != SIZE_1)
            {
                this.Height -= SPEED;
            }
            else update.Stop();
        }

        private void t_Name_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "{id:" + t_ID.Text + ",name:" + t_Name.Text + ",type:" + t_Type.Text + "}";
        }

        private void t_ID_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "{id:" + t_ID.Text + ",name:" + t_Name.Text + ",type:" + t_Type.Text + "}";
        }

        private void t_Type_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "{id:" + t_ID.Text + ",name:" + t_Name.Text + ",type:" + t_Type.Text + "}";
        }
    }
}
