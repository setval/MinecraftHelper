namespace MinecraftHelper.Forms.Tellraw
{
    partial class addScoreboard
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addSc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.t_Type = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Нет";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(5, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_addSc
            // 
            this.btn_addSc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_addSc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addSc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_addSc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSc.Location = new System.Drawing.Point(5, 49);
            this.btn_addSc.Name = "btn_addSc";
            this.btn_addSc.Size = new System.Drawing.Size(122, 23);
            this.btn_addSc.TabIndex = 9;
            this.btn_addSc.Text = "Добавить";
            this.btn_addSc.UseVisualStyleBackColor = true;
            this.btn_addSc.Click += new System.EventHandler(this.btn_addSc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(129, 49);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Отмена";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Interval = 1;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // t_Name
            // 
            this.t_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_Name.Location = new System.Drawing.Point(42, 3);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(203, 20);
            this.t_Name.TabIndex = 4;
            // 
            // t_ID
            // 
            this.t_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_ID.Location = new System.Drawing.Point(42, 25);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(203, 20);
            this.t_ID.TabIndex = 5;
            // 
            // t_Type
            // 
            this.t_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_Type.Location = new System.Drawing.Point(42, 48);
            this.t_Type.Name = "t_Type";
            this.t_Type.Size = new System.Drawing.Size(203, 20);
            this.t_Type.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.t_Name);
            this.panel1.Controls.Add(this.t_Type);
            this.panel1.Controls.Add(this.t_ID);
            this.panel1.Location = new System.Drawing.Point(5, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 71);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дополнительные значения";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип";
            // 
            // addScoreboard
            // 
            this.AcceptButton = this.btn_addSc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(258, 77);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addSc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addScoreboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить событие при ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addSc;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.TextBox t_Type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}