using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinecraftHelper.Forms
{
    public partial class TellrawForm : Form
    {
        private List<Control> controls;
        private List<TellrawObject> objects;

        public TellrawForm()
        {
            InitializeComponent();
            objects = new List<TellrawObject>();
            this.controls = new List<Control>();
            controls.Add(this.textTellraw);
            controls.Add(this.addTellraw);
            controls.Add(this.constructorGroupBox);
        }

        public List<Control> returnControls()
        {
            return controls;
        }

        public string TellrawGen()
        {
            return new TellrawGenerate(objects).returnCode();
        }

        private void addTellraw_Click(object sender, EventArgs e)
        {
            objects.Add(new TellrawObject(this.textTellraw.Text));
        }
    }
}
