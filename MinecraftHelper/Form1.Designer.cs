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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.minecraftHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockNews = new System.Windows.Forms.WebBrowser();
            this.panel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minecraftHelperToolStripMenuItem,
            this.проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem,
            this.programInfo,
            this.подключитьсяToolStripMenuItem});
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
            // 
            // проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem
            // 
            this.проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem.Name = "проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem";
            this.проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem.Size = new System.Drawing.Size(210, 20);
            this.проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem.Text = "Проверка на наличие обновлений";
            // 
            // programInfo
            // 
            this.programInfo.Name = "programInfo";
            this.programInfo.Size = new System.Drawing.Size(94, 20);
            this.programInfo.Text = "О программе";
            this.programInfo.Click += new System.EventHandler(this.programInfo_Click);
            // 
            // подключитьсяToolStripMenuItem
            // 
            this.подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            this.подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.подключитьсяToolStripMenuItem.Text = "Подключиться";
            this.подключитьсяToolStripMenuItem.Visible = false;
            this.подключитьсяToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяToolStripMenuItem_Click);
            // 
            // blockNews
            // 
            this.blockNews.Location = new System.Drawing.Point(770, 27);
            this.blockNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.blockNews.Name = "blockNews";
            this.blockNews.Size = new System.Drawing.Size(197, 386);
            this.blockNews.TabIndex = 1;
            this.blockNews.Url = new System.Uri("https://raw.githubusercontent.com/DiscoreMe/MinecraftHelper/master/news", System.UriKind.Absolute);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Location = new System.Drawing.Point(9, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(742, 372);
            this.panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.blockNews);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Minecraft Helper";
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
        private System.Windows.Forms.ToolStripMenuItem проверитьПрограммуНаНаличиеОбновленийToolStripMenuItem;
        private System.Windows.Forms.WebBrowser blockNews;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
    }
}

