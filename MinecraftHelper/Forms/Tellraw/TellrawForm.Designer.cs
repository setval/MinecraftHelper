namespace MinecraftHelper.Forms
{
    partial class TellrawForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.constructorGroupBox = new System.Windows.Forms.GroupBox();
            this.textTellraw = new System.Windows.Forms.RichTextBox();
            this.colorsTellraw = new System.Windows.Forms.ComboBox();
            this.addTellraw = new System.Windows.Forms.Button();
            this.elementsTellraw = new System.Windows.Forms.Panel();
            this.listObjects = new System.Windows.Forms.ListBox();
            this.constructorGroupBox.SuspendLayout();
            this.elementsTellraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // constructorGroupBox
            // 
            this.constructorGroupBox.Controls.Add(this.textTellraw);
            this.constructorGroupBox.Controls.Add(this.colorsTellraw);
            this.constructorGroupBox.Controls.Add(this.addTellraw);
            this.constructorGroupBox.Location = new System.Drawing.Point(12, 3);
            this.constructorGroupBox.Name = "constructorGroupBox";
            this.constructorGroupBox.Size = new System.Drawing.Size(268, 357);
            this.constructorGroupBox.TabIndex = 0;
            this.constructorGroupBox.TabStop = false;
            this.constructorGroupBox.Text = "Конструктор";
            this.constructorGroupBox.Enter += new System.EventHandler(this.constructorGroupBox_Enter);
            // 
            // textTellraw
            // 
            this.textTellraw.Location = new System.Drawing.Point(6, 19);
            this.textTellraw.Name = "textTellraw";
            this.textTellraw.Size = new System.Drawing.Size(250, 65);
            this.textTellraw.TabIndex = 3;
            this.textTellraw.Text = "";
            // 
            // colorsTellraw
            // 
            this.colorsTellraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorsTellraw.FormattingEnabled = true;
            this.colorsTellraw.Items.AddRange(new object[] {
            "Нет",
            "Красный",
            "Желтый",
            "Зеленый",
            "Синий",
            "Белый",
            "Черный"});
            this.colorsTellraw.Location = new System.Drawing.Point(6, 90);
            this.colorsTellraw.Name = "colorsTellraw";
            this.colorsTellraw.Size = new System.Drawing.Size(250, 21);
            this.colorsTellraw.TabIndex = 2;
            this.colorsTellraw.Text = "Цвет";
            // 
            // addTellraw
            // 
            this.addTellraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTellraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTellraw.Location = new System.Drawing.Point(6, 311);
            this.addTellraw.Name = "addTellraw";
            this.addTellraw.Size = new System.Drawing.Size(250, 40);
            this.addTellraw.TabIndex = 0;
            this.addTellraw.Text = "Добавить текст";
            this.addTellraw.UseVisualStyleBackColor = true;
            this.addTellraw.Click += new System.EventHandler(this.addTellraw_Click);
            // 
            // elementsTellraw
            // 
            this.elementsTellraw.AutoScroll = true;
            this.elementsTellraw.Controls.Add(this.listObjects);
            this.elementsTellraw.Location = new System.Drawing.Point(286, 10);
            this.elementsTellraw.Name = "elementsTellraw";
            this.elementsTellraw.Size = new System.Drawing.Size(433, 350);
            this.elementsTellraw.TabIndex = 1;
            // 
            // listObjects
            // 
            this.listObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listObjects.FormattingEnabled = true;
            this.listObjects.HorizontalScrollbar = true;
            this.listObjects.ItemHeight = 20;
            this.listObjects.Location = new System.Drawing.Point(3, 3);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(427, 342);
            this.listObjects.TabIndex = 0;
            this.listObjects.SelectedIndexChanged += new System.EventHandler(this.listObjects_SelectedIndexChanged);
            // 
            // TellrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 372);
            this.Controls.Add(this.elementsTellraw);
            this.Controls.Add(this.constructorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TellrawForm";
            this.Text = "TellrawForm";
            this.constructorGroupBox.ResumeLayout(false);
            this.elementsTellraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox constructorGroupBox;
        private System.Windows.Forms.Button addTellraw;
        private System.Windows.Forms.ComboBox colorsTellraw;
        private System.Windows.Forms.RichTextBox textTellraw;
        private System.Windows.Forms.Panel elementsTellraw;
        private System.Windows.Forms.ListBox listObjects;
    }
}