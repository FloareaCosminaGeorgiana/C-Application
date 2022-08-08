
namespace PAW_PROJECT
{
    partial class FormularEditareClienti
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
            this.lbPrenume = new System.Windows.Forms.GroupBox();
            this.btnReunta = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.dataNastere = new System.Windows.Forms.DateTimePicker();
            this.rdAbonamentStudent = new System.Windows.Forms.RadioButton();
            this.rbAbonamentPremium = new System.Windows.Forms.RadioButton();
            this.rdAbonamentNormal = new System.Windows.Forms.RadioButton();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbDataNasterii = new System.Windows.Forms.Label();
            this.lbTipAbonament = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPrenume.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPrenume
            // 
            this.lbPrenume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbPrenume.Controls.Add(this.panel1);
            this.lbPrenume.Controls.Add(this.btnReunta);
            this.lbPrenume.Controls.Add(this.btnSalvare);
            this.lbPrenume.Controls.Add(this.dataNastere);
            this.lbPrenume.Controls.Add(this.rdAbonamentStudent);
            this.lbPrenume.Controls.Add(this.rbAbonamentPremium);
            this.lbPrenume.Controls.Add(this.rdAbonamentNormal);
            this.lbPrenume.Controls.Add(this.tbPrenume);
            this.lbPrenume.Controls.Add(this.tbNume);
            this.lbPrenume.Controls.Add(this.lbDataNasterii);
            this.lbPrenume.Controls.Add(this.lbTipAbonament);
            this.lbPrenume.Controls.Add(this.label1);
            this.lbPrenume.Controls.Add(this.lbNume);
            this.lbPrenume.Location = new System.Drawing.Point(-1, -28);
            this.lbPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Padding = new System.Windows.Forms.Padding(2);
            this.lbPrenume.Size = new System.Drawing.Size(319, 449);
            this.lbPrenume.TabIndex = 1;
            this.lbPrenume.TabStop = false;
            // 
            // btnReunta
            // 
            this.btnReunta.FlatAppearance.BorderSize = 0;
            this.btnReunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReunta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReunta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReunta.Location = new System.Drawing.Point(199, 374);
            this.btnReunta.Name = "btnReunta";
            this.btnReunta.Size = new System.Drawing.Size(109, 36);
            this.btnReunta.TabIndex = 11;
            this.btnReunta.Text = "Cancel";
            this.btnReunta.UseVisualStyleBackColor = true;
            this.btnReunta.Click += new System.EventHandler(this.btnReunta_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.FlatAppearance.BorderSize = 0;
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvare.Location = new System.Drawing.Point(41, 374);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(109, 36);
            this.btnSalvare.TabIndex = 10;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // dataNastere
            // 
            this.dataNastere.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dataNastere.Location = new System.Drawing.Point(35, 313);
            this.dataNastere.Name = "dataNastere";
            this.dataNastere.ShowUpDown = true;
            this.dataNastere.Size = new System.Drawing.Size(258, 26);
            this.dataNastere.TabIndex = 9;
            // 
            // rdAbonamentStudent
            // 
            this.rdAbonamentStudent.AutoSize = true;
            this.rdAbonamentStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.rdAbonamentStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdAbonamentStudent.Location = new System.Drawing.Point(35, 249);
            this.rdAbonamentStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rdAbonamentStudent.Name = "rdAbonamentStudent";
            this.rdAbonamentStudent.Size = new System.Drawing.Size(171, 22);
            this.rdAbonamentStudent.TabIndex = 8;
            this.rdAbonamentStudent.TabStop = true;
            this.rdAbonamentStudent.Text = "Abonament Student";
            this.rdAbonamentStudent.UseVisualStyleBackColor = true;
            // 
            // rbAbonamentPremium
            // 
            this.rbAbonamentPremium.AutoSize = true;
            this.rbAbonamentPremium.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbAbonamentPremium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbAbonamentPremium.Location = new System.Drawing.Point(35, 218);
            this.rbAbonamentPremium.Margin = new System.Windows.Forms.Padding(2);
            this.rbAbonamentPremium.Name = "rbAbonamentPremium";
            this.rbAbonamentPremium.Size = new System.Drawing.Size(183, 22);
            this.rbAbonamentPremium.TabIndex = 7;
            this.rbAbonamentPremium.TabStop = true;
            this.rbAbonamentPremium.Text = "Abonament premium";
            this.rbAbonamentPremium.UseVisualStyleBackColor = true;
            // 
            // rdAbonamentNormal
            // 
            this.rdAbonamentNormal.AutoSize = true;
            this.rdAbonamentNormal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.rdAbonamentNormal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdAbonamentNormal.Location = new System.Drawing.Point(35, 192);
            this.rdAbonamentNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rdAbonamentNormal.Name = "rdAbonamentNormal";
            this.rdAbonamentNormal.Size = new System.Drawing.Size(169, 22);
            this.rdAbonamentNormal.TabIndex = 6;
            this.rdAbonamentNormal.TabStop = true;
            this.rdAbonamentNormal.Text = "Abonament normal";
            this.rdAbonamentNormal.UseVisualStyleBackColor = true;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbPrenume.Location = new System.Drawing.Point(35, 125);
            this.tbPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(258, 26);
            this.tbPrenume.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNume.Location = new System.Drawing.Point(35, 71);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(258, 26);
            this.tbNume.TabIndex = 4;
            // 
            // lbDataNasterii
            // 
            this.lbDataNasterii.AutoSize = true;
            this.lbDataNasterii.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbDataNasterii.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDataNasterii.Location = new System.Drawing.Point(35, 284);
            this.lbDataNasterii.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataNasterii.Name = "lbDataNasterii";
            this.lbDataNasterii.Size = new System.Drawing.Size(99, 18);
            this.lbDataNasterii.TabIndex = 3;
            this.lbDataNasterii.Text = "Data nasterii";
            // 
            // lbTipAbonament
            // 
            this.lbTipAbonament.AutoSize = true;
            this.lbTipAbonament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbTipAbonament.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTipAbonament.Location = new System.Drawing.Point(32, 158);
            this.lbTipAbonament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipAbonament.Name = "lbTipAbonament";
            this.lbTipAbonament.Size = new System.Drawing.Size(118, 18);
            this.lbTipAbonament.TabIndex = 2;
            this.lbTipAbonament.Text = "Tip abonament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prenume ";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNume.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbNume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNume.Location = new System.Drawing.Point(32, 41);
            this.lbNume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(52, 18);
            this.lbNume.TabIndex = 0;
            this.lbNume.Text = "Nume";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 432);
            this.panel1.TabIndex = 13;
            // 
            // FormularEditareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 419);
            this.Controls.Add(this.lbPrenume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularEditareClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularEditareClienti";
            this.Load += new System.EventHandler(this.FormularEditareClienti_Load);
            this.lbPrenume.ResumeLayout(false);
            this.lbPrenume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lbPrenume;
        private System.Windows.Forms.Button btnReunta;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.DateTimePicker dataNastere;
        private System.Windows.Forms.RadioButton rdAbonamentStudent;
        private System.Windows.Forms.RadioButton rbAbonamentPremium;
        private System.Windows.Forms.RadioButton rdAbonamentNormal;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbDataNasterii;
        private System.Windows.Forms.Label lbTipAbonament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Panel panel1;
    }
}