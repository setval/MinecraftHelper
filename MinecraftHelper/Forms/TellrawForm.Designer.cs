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
            this.textTellraw = new System.Windows.Forms.TextBox();
            this.addTellraw = new System.Windows.Forms.Button();
            this.constructorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // constructorGroupBox
            // 
            this.constructorGroupBox.Controls.Add(this.textTellraw);
            this.constructorGroupBox.Controls.Add(this.addTellraw);
            this.constructorGroupBox.Location = new System.Drawing.Point(12, 3);
            this.constructorGroupBox.Name = "constructorGroupBox";
            this.constructorGroupBox.Size = new System.Drawing.Size(252, 315);
            this.constructorGroupBox.TabIndex = 0;
            this.constructorGroupBox.TabStop = false;
            this.constructorGroupBox.Text = "Конструктор";
            // 
            // textTellraw
            // 
            this.textTellraw.Location = new System.Drawing.Point(21, 19);
            this.textTellraw.Multiline = true;
            this.textTellraw.Name = "textTellraw";
            this.textTellraw.Size = new System.Drawing.Size(235, 44);
            this.textTellraw.TabIndex = 1;
            // 
            // addTellraw
            // 
            this.addTellraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTellraw.Location = new System.Drawing.Point(21, 269);
            this.addTellraw.Name = "addTellraw";
            this.addTellraw.Size = new System.Drawing.Size(235, 40);
            this.addTellraw.TabIndex = 0;
            this.addTellraw.Text = "Добавить текст";
            this.addTellraw.UseVisualStyleBackColor = true;
            this.addTellraw.Click += new System.EventHandler(this.addTellraw_Click);
            // 
            // TellrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 333);
            this.Controls.Add(this.constructorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TellrawForm";
            this.Text = "TellrawForm";
            this.constructorGroupBox.ResumeLayout(false);
            this.constructorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox constructorGroupBox;
        private System.Windows.Forms.TextBox textTellraw;
        private System.Windows.Forms.Button addTellraw;
    }
}