using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MinecraftHelper.Forms.Tellraw;

namespace MinecraftHelper.Forms
{
    public partial class TellrawForm : Form
    {
        private List<Control> controls;
        private List<TellrawObject> objects;
        public List<List<Control>> tellrawElementsForm;

        private const int width = 35;
        private bool is_aSC_PRESS = false;
        private bool is_aSC_GUIDANCE = false;

        private List<Scoreboard> scoreboards = null;
        private Scoreboard scoreboard_press = null;
        private Scoreboard scoreboard_guidance = null;

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
            if (!is_aSC_PRESS && !is_aSC_GUIDANCE) scoreboards = new List<Scoreboard>{new Scoreboard(ScoreboardTypes.NONE), new Scoreboard(ScoreboardTypes.NONE)};
            if (!is_aSC_PRESS && is_aSC_GUIDANCE) scoreboards = new List<Scoreboard> { new Scoreboard(ScoreboardTypes.NONE), scoreboard_guidance };
            if (is_aSC_PRESS && !is_aSC_GUIDANCE) { scoreboards = new List<Scoreboard> { scoreboard_press, new Scoreboard(ScoreboardTypes.NONE) }; }
            TellrawObject TellrawObject = new TellrawObject(this.textTellraw.Text, word[index], listFormatis, scoreboards);
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

            is_aSC_PRESS = false;
            addScP_PRESS.Text = "Нажатии";
            addScP_PRESS.ForeColor = System.Drawing.Color.Black;

            is_aSC_GUIDANCE = false;
            addScP_GUIDANCE.Text = "Наведении";
            addScP_GUIDANCE.ForeColor = System.Drawing.Color.Black;
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

        void addSc(int code)
        {
            if (code == 1)
            {
                if (is_aSC_PRESS)
                {
                    addScP_PRESS.Text = "Нажатии";
                    addScP_PRESS.ForeColor = System.Drawing.Color.Black;
                    is_aSC_PRESS = false;
                }
                else
                {
                    
                    addScoreboard asc = new addScoreboard("нажатии", new List<string>{"Нет", "Выполнить команду", "Предложить команду", "Открыть URL", "Сменить страницу"});
                    asc.ShowDialog();
                    if (asc.dr == DialogResult.OK)
                    {
                        if (asc.comboBox1.SelectedIndex == 0 || asc.comboBox1.SelectedIndex == -1) return;
                        addScP_PRESS.Text = "Удалить";
                        addScP_PRESS.ForeColor = System.Drawing.Color.Red;
                        is_aSC_PRESS = true;
                        ScoreboardTypes scT;
                        switch (asc.comboBox1.SelectedIndex)
                        {
                            case 1: scT = ScoreboardTypes.DO_COMMAND; break;
                            case 2: scT = ScoreboardTypes.INVITE_COMMAND; break;
                            case 3: scT = ScoreboardTypes.OPEN_URL; break;
                            case 4: scT = ScoreboardTypes.CHANGE_PAGE; break;
                            default: scT = ScoreboardTypes.NONE; break;
                        }
                        scoreboard_press = new Scoreboard(ScoreboardTypes.PRESS, scT, asc.textBox1.Text);
                    }
                }
            }
            else
            {
                if (is_aSC_GUIDANCE)
                {
                    addScP_GUIDANCE.Text = "Наведении";
                    addScP_GUIDANCE.ForeColor = System.Drawing.Color.Black;
                    is_aSC_GUIDANCE = false;
                }
                else
                {
                    addScoreboard asc = new addScoreboard("наведении", new List<string> {"Нет", "Показать текст", "Показать предмет", "Показать сущность (НЕ РАБОТАЕТ)", "Показать достижение"});
                    asc.ShowDialog();
                    if (asc.dr == DialogResult.OK)
                    {
                        if (asc.comboBox1.SelectedIndex == 0 || asc.comboBox1.SelectedIndex == -1) return;
                        addScP_GUIDANCE.Text = "Удалить";
                        addScP_GUIDANCE.ForeColor = System.Drawing.Color.Red;
                        is_aSC_GUIDANCE = true;
                        ScoreboardTypes scT;
                        switch (asc.comboBox1.SelectedIndex)
                        {
                            case 1: scT = ScoreboardTypes.SHOW_TEXT; break;
                            case 2: scT = ScoreboardTypes.SHOW_ITEM; break;
                            case 3: scT = ScoreboardTypes.SHOW_ENTITY; break;
                            case 4: scT = ScoreboardTypes.SHOW_ATTAINMENT; break;
                            default: scT = ScoreboardTypes.NONE; break;
                        }
                        scoreboard_guidance = new Scoreboard(ScoreboardTypes.GUIDANCE, scT, asc.textBox1.Text);
                    }
                }
            }
        }

        private void addScP_Click(object sender, EventArgs e)
        {
            addSc(1);
        }
        private void addScP_GUIDANCE_Click(object sender, EventArgs e)
        {
            addSc(2);
        }

    }
}
