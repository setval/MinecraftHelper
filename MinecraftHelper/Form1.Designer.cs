namespace MinecraftHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.minecraftHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.blockNews = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.clearGen = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minecraftHelperToolStripMenuItem,
            this.подключитьсяToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.programInfo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(967, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // minecraftHelperToolStripMenuItem
            // 
            this.minecraftHelperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tellrawToolStripMenuItem});
            this.minecraftHelperToolStripMenuItem.Name = "minecraftHelperToolStripMenuItem";
            this.minecraftHelperToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.minecraftHelperToolStripMenuItem.Text = "Minecraft Helper";
            // 
            // tellrawToolStripMenuItem
            // 
            this.tellrawToolStripMenuItem.Name = "tellrawToolStripMenuItem";
            this.tellrawToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.tellrawToolStripMenuItem.Text = "Tellraw";
            this.tellrawToolStripMenuItem.Click += new System.EventHandler(this.tellrawToolStripMenuItem_Click);
            // 
            // подключитьсяToolStripMenuItem
            // 
            this.подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            this.подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.подключитьсяToolStripMenuItem.Text = "Подключиться";
            this.подключитьсяToolStripMenuItem.Visible = false;
            this.подключитьсяToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // programInfo
            // 
            this.programInfo.Name = "programInfo";
            this.programInfo.Size = new System.Drawing.Size(94, 20);
            this.programInfo.Text = "О программе";
            this.programInfo.Click += new System.EventHandler(this.programInfo_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Location = new System.Drawing.Point(9, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(742, 372);
            this.panel.TabIndex = 2;
            // 
            // blockNews
            // 
            this.blockNews.Location = new System.Drawing.Point(757, 28);
            this.blockNews.MaxLength = 0;
            this.blockNews.Multiline = true;
            this.blockNews.Name = "blockNews";
            this.blockNews.ReadOnly = true;
            this.blockNews.Size = new System.Drawing.Size(203, 319);
            this.blockNews.TabIndex = 4;
            this.blockNews.Text = ".";
            this.blockNews.MouseEnter += new System.EventHandler(this.blockNews_MouseEnter);
            this.blockNews.MouseLeave += new System.EventHandler(this.blockNews_MouseLeave);
            // 
            // gen
            // 
            this.gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gen.Location = new System.Drawing.Point(757, 355);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(140, 45);
            this.gen.TabIndex = 5;
            this.gen.Text = "Сгенерировать команду";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearGen
            // 
            this.clearGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearGen.Location = new System.Drawing.Point(907, 355);
            this.clearGen.Name = "clearGen";
            this.clearGen.Size = new System.Drawing.Size(53, 45);
            this.clearGen.TabIndex = 6;
            this.clearGen.Text = "X";
            this.clearGen.UseVisualStyleBackColor = true;
            this.clearGen.Click += new System.EventHandler(this.clearGen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.clearGen);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.blockNews);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Helper by Discore ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem minecraftHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programInfo;
        private System.Windows.Forms.ToolStripMenuItem tellrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox blockNews;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Button clearGen;
    }
}

