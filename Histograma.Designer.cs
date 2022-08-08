
namespace PAW_PROJECT
{
    partial class Histograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histograma));
            this.button1 = new System.Windows.Forms.Button();
            this.histograma1 = new BibliotecaHistograma.Histograma();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(721, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 53);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // histograma1
            // 
            this.histograma1.Location = new System.Drawing.Point(1, 11);
            this.histograma1.Margin = new System.Windows.Forms.Padding(2);
            this.histograma1.Name = "histograma1";
            this.histograma1.Size = new System.Drawing.Size(694, 406);
            this.histograma1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(816, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Histograma
            // 
            this.ClientSize = new System.Drawing.Size(922, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.histograma1);
            this.Name = "Histograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

     //   private BibliotecaHistograma.Histograma histograma1;
        private System.Windows.Forms.Button button1;
        private BibliotecaHistograma.Histograma histograma1;
        private System.Windows.Forms.Button button2;
        // private BibliotecaHistograma.Histograma histograma1;
    }
}