using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MinecraftHelper.Forms.Tellraw;

namespace MinecraftHelper.Forms
{
    public partial class TellrawForm : Form
    {
        private List<Control> controls;
        private List<TellrawObject> objects;
        public List<List<Control>> tellrawElementsForm;

        private bool hideShowList = true;
        private const int width = 35;

        public TellrawForm()
        {
            InitializeComponent();
            objects = new List<TellrawObject>();
            tellrawElementsForm = new List<List<Control>>();
            this.controls = new List<Control>();
            controls.Add(this.constructorGroupBox);
            controls.Add(this.elementsTellraw);
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
            List<string> word_orign = new List<string>();
            List<string> word = new List<string>();
            word.Add("");
            word.Add("red");
            word.Add("yellow");
            word.Add("green");
            word.Add("blue");
            word.Add("white");
            word.Add("black");
            word.Add("aqua");
            word.Add("gold");
            word.Add("purple");
            word.Add("dark_red");
            word.Add("dark_yellow");
            word.Add("dark_green");
            word.Add("dark_blue");
            word.Add("dark_purple");
            word.Add("dark_aqua");
            word.Add("gray");

            int index = colorsTellraw.Items.IndexOf(colorsTellraw.Text);
            if (index == -1) index = 0;

            List<string> listFormatis = new List<string>();
            foreach (int indexChecked in listFormats.CheckedIndices)
                switch(indexChecked)
                {
                    case 0: listFormatis.Add("bold"); break;
                    case 1: listFormatis.Add("italic"); break;
                    case 2: listFormatis.Add("underlined"); break;
                    case 3: listFormatis.Add("strikethrough"); break;
                    case 4: listFormatis.Add("obfuscated"); break;
                }  
            TellrawObject TellrawObject = new TellrawObject(this.textTellraw.Text, word[index], listFormatis);
            objects.Add(TellrawObject);
            this.textTellraw.Text = "";
            this.colorsTellraw.Text = "Цвет";

            UpdateElementsPanel();
        }
  

        public virtual void removeTellrawElement(List<Control> c)
        {
            MessageBox.Show(returnTellrawElementsForm().Count.ToString());
            this.tellrawElementsForm.Remove(c);
            MessageBox.Show(this.tellrawElementsForm.Count.ToString());
        }

        private List<List<Control>> returnTellrawElementsForm()
        {
            return tellrawElementsForm;
        }

        private void UpdateElementsPanel()
        {
            listObjects.Items.Clear();
            listFormats.ClearSelected();
            listFormats.SetItemChecked(0, false);
            listFormats.SetItemChecked(1, false);
            listFormats.SetItemChecked(2, false);
            listFormats.SetItemChecked(3, false);
            listFormats.SetItemChecked(4, false);

            foreach (TellrawObject obj in objects)
            {
                if (obj.getText().Equals(""))
                    listObjects.Items.Add("(Пусто)");
                else
                    listObjects.Items.Add(obj.getText());
            }
        }

        private void listObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listObjects.SelectedIndex;            
            if (i != -1)
            {
                string texts = (objects[i].getText() != "") ? objects[i].getText() : "(Пусто)";
                string color = (objects[i].getColor() != "") ? returnRussianWord(objects[i].getColor()) : "(Пусто)";
                string formats;
                if (objects[i].getListFormats().Count == 0)
                    formats = "(Пусто)";
                else
                {
                    formats = "";
                    foreach (string obj in objects[i].getListFormats())
                        formats += returnRussianWord(obj) + ", ";
                    formats = formats.Substring(0, formats.Length - 2);
                }
                        
              /*  foreach (string obj in objects[i].getListFormats())
                    MessageBox.Show(obj);
                    */
                ShowTellrawForm.Show(texts, color, formats);
            }
        }

        private void listFormats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string returnRussianWord(string word)
        {
            string returnWord = "";
            switch(word)
            {
                case "red": returnWord = "Красный"; break;
                case "yellow": returnWord = "Желтый"; break;
                case "green": returnWord = "Зеленый"; break;
                case "blue": returnWord = "Синий"; break;
                case "white": returnWord = "Белый"; break;
                case "black": returnWord = "Черный"; break;
                case "bold": returnWord = "Жирный"; break;
                case "italic": returnWord = "Курсив"; break;
                case "underlined": returnWord = "Подчеркнутый"; break;
                case "strikethrough": returnWord = "Зачеркнутый"; break;
                case "obfuscated": returnWord = "Запутанный"; break;
                case "aqua": returnWord = "Бирюзовый"; break;
                case "gold": returnWord = "Золотой"; break;
                case "purple": returnWord = "Пурпуровый"; break;
                case "dark_red": returnWord = "Темно-красный"; break;
                case "dark_yellow": returnWord = "Темно-желтый"; break;
                case "dark_green": returnWord = "Темно-зеленый"; break;
                case "dark_blue": returnWord = "Темно-синий"; break;
                case "gray": returnWord = "Серый"; break;
                case "":
                default: returnWord = ""; break;
            }
            return returnWord;
        }

     
        private void addScP_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_showhidelist_Click(object sender, EventArgs e)
        {
            if (hideShowList)
            {
                hideShowList = false;
                btn_showhidelist.Text = "Показать список";
                listObjects.Visible = false;
            }
            else
            {
                hideShowList = true;
                btn_showhidelist.Text = "Скрыть список";
                listObjects.Visible = true;
            }
        }
    }
}
