namespace praktikum14
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
            this.inputlabel = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.REVERSE = new System.Windows.Forms.Button();
            this.URUTKAN = new System.Windows.Forms.Button();
            this.OUTPUT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputlabel
            // 
            this.inputlabel.AutoSize = true;
            this.inputlabel.Location = new System.Drawing.Point(44, 56);
            this.inputlabel.Name = "inputlabel";
            this.inputlabel.Size = new System.Drawing.Size(46, 20);
            this.inputlabel.TabIndex = 0;
            this.inputlabel.Text = "Input";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(50, 93);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(282, 26);
            this.inputbox.TabIndex = 1;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // REVERSE
            // 
            this.REVERSE.Location = new System.Drawing.Point(53, 154);
            this.REVERSE.Name = "REVERSE";
            this.REVERSE.Size = new System.Drawing.Size(115, 37);
            this.REVERSE.TabIndex = 2;
            this.REVERSE.Text = "REVERSE";
            this.REVERSE.UseVisualStyleBackColor = true;
            this.REVERSE.Click += new System.EventHandler(this.REVERSE_Click);
            // 
            // URUTKAN
            // 
            this.URUTKAN.Location = new System.Drawing.Point(222, 154);
            this.URUTKAN.Name = "URUTKAN";
            this.URUTKAN.Size = new System.Drawing.Size(110, 37);
            this.URUTKAN.TabIndex = 3;
            this.URUTKAN.Text = "URUTKAN";
            this.URUTKAN.UseVisualStyleBackColor = true;
            this.URUTKAN.Click += new System.EventHandler(this.URUTKAN_Click);
            // 
            // OUTPUT
            // 
            this.OUTPUT.AutoSize = true;
            this.OUTPUT.Location = new System.Drawing.Point(58, 229);
            this.OUTPUT.Name = "OUTPUT";
            this.OUTPUT.Size = new System.Drawing.Size(58, 20);
            this.OUTPUT.TabIndex = 4;
            this.OUTPUT.Text = "Output";
            this.OUTPUT.Click += new System.EventHandler(this.OUTPUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OUTPUT);
            this.Controls.Add(this.URUTKAN);
            this.Controls.Add(this.REVERSE);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.inputlabel);
            this.Name = "Form1";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputlabel;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button REVERSE;
        private System.Windows.Forms.Button URUTKAN;
        private System.Windows.Forms.Label OUTPUT;
    }
}

