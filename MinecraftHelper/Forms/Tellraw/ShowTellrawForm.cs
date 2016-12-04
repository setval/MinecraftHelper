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
    public partial class ShowTellrawForm : Form
    {
        public ShowTellrawForm()
        {
            InitializeComponent();
        }

        static ShowTellrawForm MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string color, string format, string scoreboard)
        {
            MsgBox = new ShowTellrawForm();
            MsgBox.text.Text = text;
            MsgBox.color.Text = color;
            MsgBox.format.Text = format;
            MsgBox.l_scoreboard.Text = scoreboard;
            MsgBox.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
