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
    public partial class TellrawElementsForm : Form
    {
        private List<Control> controls;

        public TellrawElementsForm()
        {
            InitializeComponent();
            controls = new List<Control>();
        }

        public List<Control> returnControls()
        {
            controls.Clear();

            controls.Add(this.showElement_);
            controls.Add(this.deleteElement_);
            controls.Add(this.panelElement_);
            return controls;
        }
  
    }
}
