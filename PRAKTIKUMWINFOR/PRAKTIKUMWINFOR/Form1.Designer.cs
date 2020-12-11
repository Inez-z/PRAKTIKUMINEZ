namespace PRAKTIKUMWINFOR
{
    partial class Formdata
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
            this.lnputan = new System.Windows.Forms.Label();
            this.tombolproses = new System.Windows.Forms.Button();
            this.inputteks = new System.Windows.Forms.TextBox();
            this.EMPTY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnputan
            // 
            this.lnputan.AutoSize = true;
            this.lnputan.Location = new System.Drawing.Point(26, 32);
            this.lnputan.Name = "lnputan";
            this.lnputan.Size = new System.Drawing.Size(93, 20);
            this.lnputan.TabIndex = 0;
            this.lnputan.Text = "Input Data :";
            // 
            // tombolproses
            // 
            this.tombolproses.Location = new System.Drawing.Point(30, 145);
            this.tombolproses.Name = "tombolproses";
            this.tombolproses.Size = new System.Drawing.Size(120, 34);
            this.tombolproses.TabIndex = 1;
            this.tombolproses.Text = "Proses";
            this.tombolproses.UseVisualStyleBackColor = true;
            this.tombolproses.Click += new System.EventHandler(this.tombolproses_Click);
            // 
            // inputteks
            // 
            this.inputteks.Location = new System.Drawing.Point(30, 82);
            this.inputteks.Name = "inputteks";
            this.inputteks.Size = new System.Drawing.Size(231, 26);
            this.inputteks.TabIndex = 2;
            this.inputteks.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EMPTY
            // 
            this.EMPTY.AutoSize = true;
            this.EMPTY.Location = new System.Drawing.Point(41, 230);
            this.EMPTY.Name = "EMPTY";
            this.EMPTY.Size = new System.Drawing.Size(71, 20);
            this.EMPTY.TabIndex = 3;
            this.EMPTY.Text = "[EMPTY]";
            this.EMPTY.Click += new System.EventHandler(this.EMPTY_Click);
            // 
            // Formdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EMPTY);
            this.Controls.Add(this.inputteks);
            this.Controls.Add(this.tombolproses);
            this.Controls.Add(this.lnputan);
            this.Name = "Formdata";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnputan;
        private System.Windows.Forms.Button tombolproses;
        private System.Windows.Forms.TextBox inputteks;
        private System.Windows.Forms.Label EMPTY;
    }
}

