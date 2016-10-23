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

        public Control returnPanelElement()
        {
            return panelElement_;
        }

        public Control returnShowElement()
        {
            return showElement_;
        }

        public Control returnDeleteElement()
        {
            return deleteElement_;
        }

        public void setText(string element, string text)
        {
            this.Controls[element].Text = text;
        }

        public void setText(Control control, string text)
        {
            control.Text = text;
        }

        public void setName(Control control, string name)
        {
            control.Name = name;
        }

        public void setName(string element, string name)
        {
            this.Controls[element].Name = Name;
        }

        public string getText(Control control)
        {
            return control.Text;
        }

        public string getName(Control control)
        {
            return control.Name;
        }

        public Point getPos(string element)
        {
            return this.Controls[element].Location;
        }

        public Point getPos(Control control)
        {
            return control.Location;
        }

        public void setPos(Control control, Point point)
        {
            control.Location = point;
        }

  
    }
}
