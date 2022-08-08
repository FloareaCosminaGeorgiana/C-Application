
namespace PAW_PROJECT
{
    partial class FormClipBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClipBoard));
            this.dst = new System.Windows.Forms.PictureBox();
            this.src = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.tbDst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.src)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dst
            // 
            this.dst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dst.Location = new System.Drawing.Point(439, 53);
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(258, 133);
            this.dst.TabIndex = 0;
            this.dst.TabStop = false;
            // 
            // src
            // 
            this.src.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.src.Location = new System.Drawing.Point(22, 53);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(258, 133);
            this.src.TabIndex = 1;
            this.src.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSwitch.Location = new System.Drawing.Point(300, 94);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(116, 65);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "Schimba";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // tbSrc
            // 
            this.tbSrc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbSrc.Location = new System.Drawing.Point(22, 278);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(258, 26);
            this.tbSrc.TabIndex = 3;
            // 
            // tbDst
            // 
            this.tbDst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbDst.Location = new System.Drawing.Point(439, 278);
            this.tbDst.Name = "tbDst";
            this.tbDst.Size = new System.Drawing.Size(258, 26);
            this.tbDst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(112, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sursa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(536, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destinatie";
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopy.Location = new System.Drawing.Point(51, 330);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(129, 29);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPaste.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaste.Location = new System.Drawing.Point(492, 330);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(167, 23);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDst);
            this.panel1.Controls.Add(this.tbSrc);
            this.panel1.Controls.Add(this.src);
            this.panel1.Controls.Add(this.dst);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 375);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(663, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 32);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(351, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 452);
            this.panel2.TabIndex = 9;
            // 
            // FormClipBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClipBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClipBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.src)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dst;
        private System.Windows.Forms.PictureBox src;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.TextBox tbDst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}