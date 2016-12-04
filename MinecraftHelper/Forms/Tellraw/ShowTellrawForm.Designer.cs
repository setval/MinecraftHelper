namespace MinecraftHelper.Forms.Tellraw
{
    partial class ShowTellrawForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.Label();
            this.l_scoreboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(243, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст:\r\n\r\nЦвет:\r\n\r\nФормат:";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(59, 16);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(239, 20);
            this.text.TabIndex = 2;
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(70, 45);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(32, 13);
            this.color.TabIndex = 3;
            this.color.Text = "Цвет";
            // 
            // format
            // 
            this.format.AutoSize = true;
            this.format.Location = new System.Drawing.Point(70, 71);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(49, 13);
            this.format.TabIndex = 4;
            this.format.Text = "Формат";
            // 
            // l_scoreboard
            // 
            this.l_scoreboard.AutoSize = true;
            this.l_scoreboard.Location = new System.Drawing.Point(12, 95);
            this.l_scoreboard.Name = "l_scoreboard";
            this.l_scoreboard.Size = new System.Drawing.Size(71, 13);
            this.l_scoreboard.TabIndex = 5;
            this.l_scoreboard.Text = "События нет";
            // 
            // ShowTellrawForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.Controls.Add(this.l_scoreboard);
            this.Controls.Add(this.format);
            this.Controls.Add(this.color);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowTellrawForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label format;
        private System.Windows.Forms.Label l_scoreboard;
    }
}