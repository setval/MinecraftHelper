namespace MinecraftHelper.Forms
{
    partial class TellrawElementsForm
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
            this.showElement_ = new System.Windows.Forms.Button();
            this.deleteElement_ = new System.Windows.Forms.Button();
            this.panelElement_ = new System.Windows.Forms.Panel();
            this.panelElement_.SuspendLayout();
            this.SuspendLayout();
            // 
            // showElement_
            // 
            this.showElement_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showElement_.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showElement_.Location = new System.Drawing.Point(3, 3);
            this.showElement_.Name = "showElement_";
            this.showElement_.Size = new System.Drawing.Size(355, 26);
            this.showElement_.TabIndex = 0;
            this.showElement_.Text = "Показать информацию";
            this.showElement_.UseVisualStyleBackColor = true;
            // 
            // deleteElement_
            // 
            this.deleteElement_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteElement_.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteElement_.Location = new System.Drawing.Point(364, 3);
            this.deleteElement_.Name = "deleteElement_";
            this.deleteElement_.Size = new System.Drawing.Size(43, 26);
            this.deleteElement_.TabIndex = 1;
            this.deleteElement_.Text = "X";
            this.deleteElement_.UseVisualStyleBackColor = true;
            // 
            // panelElement_
            // 
            this.panelElement_.Controls.Add(this.deleteElement_);
            this.panelElement_.Controls.Add(this.showElement_);
            this.panelElement_.Location = new System.Drawing.Point(0, 0);
            this.panelElement_.Name = "panelElement_";
            this.panelElement_.Size = new System.Drawing.Size(410, 32);
            this.panelElement_.TabIndex = 2;
            // 
            // TellrawElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 32);
            this.Controls.Add(this.panelElement_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TellrawElementsForm";
            this.Text = "TellrawElementsForm";
            this.panelElement_.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showElement_;
        private System.Windows.Forms.Button deleteElement_;
        private System.Windows.Forms.Panel panelElement_;
    }
}