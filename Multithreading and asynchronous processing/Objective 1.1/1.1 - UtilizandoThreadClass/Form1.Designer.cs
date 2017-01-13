namespace _1._1___UtilizandoThreadClass
{
    partial class Form1
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
            this.rtbThreadOutput = new System.Windows.Forms.RichTextBox();
            this.chkIsBackground = new System.Windows.Forms.CheckBox();
            this.chkThreadJoin = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thread Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbThreadOutput
            // 
            this.rtbThreadOutput.Location = new System.Drawing.Point(12, 189);
            this.rtbThreadOutput.Name = "rtbThreadOutput";
            this.rtbThreadOutput.Size = new System.Drawing.Size(382, 189);
            this.rtbThreadOutput.TabIndex = 1;
            this.rtbThreadOutput.Text = "";
            // 
            // chkIsBackground
            // 
            this.chkIsBackground.AutoSize = true;
            this.chkIsBackground.Location = new System.Drawing.Point(12, 61);
            this.chkIsBackground.Name = "chkIsBackground";
            this.chkIsBackground.Size = new System.Drawing.Size(92, 17);
            this.chkIsBackground.TabIndex = 2;
            this.chkIsBackground.Text = "IsBackground";
            this.chkIsBackground.UseVisualStyleBackColor = true;
            // 
            // chkThreadJoin
            // 
            this.chkThreadJoin.AutoSize = true;
            this.chkThreadJoin.Location = new System.Drawing.Point(12, 93);
            this.chkThreadJoin.Name = "chkThreadJoin";
            this.chkThreadJoin.Size = new System.Drawing.Size(82, 17);
            this.chkThreadJoin.TabIndex = 3;
            this.chkThreadJoin.Text = "Thread Join";
            this.chkThreadJoin.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 127);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbClear
            // 
            this.cbClear.Location = new System.Drawing.Point(108, 12);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(75, 23);
            this.cbClear.TabIndex = 5;
            this.cbClear.Text = "Clear";
            this.cbClear.UseVisualStyleBackColor = true;
            this.cbClear.Click += new System.EventHandler(this.cbClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 390);
            this.Controls.Add(this.cbClear);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.chkThreadJoin);
            this.Controls.Add(this.chkIsBackground);
            this.Controls.Add(this.rtbThreadOutput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbThreadOutput;
        private System.Windows.Forms.CheckBox chkIsBackground;
        private System.Windows.Forms.CheckBox chkThreadJoin;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button cbClear;
    }
}

