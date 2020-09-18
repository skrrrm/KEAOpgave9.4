namespace KEAOpgave9._4
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
            this.listBoxX = new System.Windows.Forms.ListBox();
            this.listBoxY = new System.Windows.Forms.ListBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxX
            // 
            this.listBoxX.FormattingEnabled = true;
            this.listBoxX.ItemHeight = 16;
            this.listBoxX.Location = new System.Drawing.Point(58, 44);
            this.listBoxX.Name = "listBoxX";
            this.listBoxX.Size = new System.Drawing.Size(153, 212);
            this.listBoxX.TabIndex = 0;
            // 
            // listBoxY
            // 
            this.listBoxY.FormattingEnabled = true;
            this.listBoxY.ItemHeight = 16;
            this.listBoxY.Location = new System.Drawing.Point(260, 44);
            this.listBoxY.Name = "listBoxY";
            this.listBoxY.Size = new System.Drawing.Size(153, 212);
            this.listBoxY.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(55, 24);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 17);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(257, 24);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 17);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(153, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.listBoxY);
            this.Controls.Add(this.listBoxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxX;
        private System.Windows.Forms.ListBox listBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

