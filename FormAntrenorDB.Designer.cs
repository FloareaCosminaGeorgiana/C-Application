
namespace PAW_PROJECT
{
    partial class FormAntrenorDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAntrenorDB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAntrenor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxAntrenor = new System.Windows.Forms.ListBox();
            this.btnAdaugaClienti = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbNrClienti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugaEditeaza = new System.Windows.Forms.Button();
            this.tbPrenumeA = new System.Windows.Forms.TextBox();
            this.tbNumeA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarCliientiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antrenor2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAntrenori = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnGrafic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenor2BindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.groupBox1.Controls.Add(this.cbAntrenor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listboxAntrenor);
            this.groupBox1.Controls.Add(this.btnAdaugaClienti);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.tbNrClienti);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnStergere);
            this.groupBox1.Controls.Add(this.btnAdaugaEditeaza);
            this.groupBox1.Controls.Add(this.tbPrenumeA);
            this.groupBox1.Controls.Add(this.tbNumeA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Location = new System.Drawing.Point(0, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(809, 496);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii antrenor";
            // 
            // cbAntrenor
            // 
            this.cbAntrenor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbAntrenor.FormattingEnabled = true;
            this.cbAntrenor.Location = new System.Drawing.Point(20, 404);
            this.cbAntrenor.Name = "cbAntrenor";
            this.cbAntrenor.Size = new System.Drawing.Size(148, 26);
            this.cbAntrenor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Antrenor";
            // 
            // listboxAntrenor
            // 
            this.listboxAntrenor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.listboxAntrenor.FormattingEnabled = true;
            this.listboxAntrenor.ItemHeight = 18;
            this.listboxAntrenor.Location = new System.Drawing.Point(20, 250);
            this.listboxAntrenor.Name = "listboxAntrenor";
            this.listboxAntrenor.Size = new System.Drawing.Size(228, 94);
            this.listboxAntrenor.TabIndex = 14;
            // 
            // btnAdaugaClienti
            // 
            this.btnAdaugaClienti.FlatAppearance.BorderSize = 0;
            this.btnAdaugaClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaClienti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdaugaClienti.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaClienti.Location = new System.Drawing.Point(197, 409);
            this.btnAdaugaClienti.Name = "btnAdaugaClienti";
            this.btnAdaugaClienti.Size = new System.Drawing.Size(215, 42);
            this.btnAdaugaClienti.TabIndex = 13;
            this.btnAdaugaClienti.Text = "Adauga clienti";
            this.btnAdaugaClienti.UseVisualStyleBackColor = true;
            this.btnAdaugaClienti.Click += new System.EventHandler(this.btnAdaugaClienti_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(2, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(106, 17);
            this.statusStripLabel.Text = "Numar clienti:0";
            // 
            // tbNrClienti
            // 
            this.tbNrClienti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNrClienti.Location = new System.Drawing.Point(20, 196);
            this.tbNrClienti.Name = "tbNrClienti";
            this.tbNrClienti.Size = new System.Drawing.Size(170, 26);
            this.tbNrClienti.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numar clienti";
            // 
            // btnStergere
            // 
            this.btnStergere.FlatAppearance.BorderSize = 0;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(622, 415);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(101, 36);
            this.btnStergere.TabIndex = 11;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugaEditeaza
            // 
            this.btnAdaugaEditeaza.FlatAppearance.BorderSize = 0;
            this.btnAdaugaEditeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaEditeaza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdaugaEditeaza.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaEditeaza.Location = new System.Drawing.Point(448, 415);
            this.btnAdaugaEditeaza.Name = "btnAdaugaEditeaza";
            this.btnAdaugaEditeaza.Size = new System.Drawing.Size(111, 36);
            this.btnAdaugaEditeaza.TabIndex = 10;
            this.btnAdaugaEditeaza.Text = "Adauga/Editeaza";
            this.btnAdaugaEditeaza.UseVisualStyleBackColor = true;
            this.btnAdaugaEditeaza.Click += new System.EventHandler(this.btnAdaugaEditeaza_Click);
            // 
            // tbPrenumeA
            // 
            this.tbPrenumeA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbPrenumeA.Location = new System.Drawing.Point(20, 116);
            this.tbPrenumeA.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenumeA.Name = "tbPrenumeA";
            this.tbPrenumeA.Size = new System.Drawing.Size(170, 26);
            this.tbPrenumeA.TabIndex = 5;
            // 
            // tbNumeA
            // 
            this.tbNumeA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNumeA.Location = new System.Drawing.Point(20, 44);
            this.tbNumeA.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumeA.Name = "tbNumeA";
            this.tbNumeA.Size = new System.Drawing.Size(170, 26);
            this.tbNumeA.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prenume ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nume";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.numarCliientiDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.antrenor2BindingSource;
            this.dgv.Location = new System.Drawing.Point(312, 47);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(441, 361);
            this.dgv.TabIndex = 14;
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // numarCliientiDataGridViewTextBoxColumn
            // 
            this.numarCliientiDataGridViewTextBoxColumn.DataPropertyName = "numarCliienti";
            this.numarCliientiDataGridViewTextBoxColumn.HeaderText = "numarCliienti";
            this.numarCliientiDataGridViewTextBoxColumn.Name = "numarCliientiDataGridViewTextBoxColumn";
            // 
            // antrenor2BindingSource
            // 
            this.antrenor2BindingSource.DataSource = typeof(PAW_PROJECT.Antrenor2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(5)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAntrenori,
            this.toolStripSeparator1,
            this.toolStripBtnPrint,
            this.toolStripSeparator2,
            this.toolStripBtnGrafic,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAntrenori
            // 
            this.toolStripBtnAntrenori.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAntrenori.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAntrenori.Image")));
            this.toolStripBtnAntrenori.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAntrenori.Name = "toolStripBtnAntrenori";
            this.toolStripBtnAntrenori.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnAntrenori.Text = "Antrenori";
            this.toolStripBtnAntrenori.ToolTipText = "Clienti";
            this.toolStripBtnAntrenori.Click += new System.EventHandler(this.toolStripBtnAntrenori_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnPrint
            // 
            this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
            this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrint.Name = "toolStripBtnPrint";
            this.toolStripBtnPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnPrint.Text = "printare";
            this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnGrafic
            // 
            this.toolStripBtnGrafic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGrafic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGrafic.Image")));
            this.toolStripBtnGrafic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGrafic.Name = "toolStripBtnGrafic";
            this.toolStripBtnGrafic.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnGrafic.Text = "Grafic";
            this.toolStripBtnGrafic.Click += new System.EventHandler(this.toolStripBtnGrafic_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(-15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 510);
            this.panel1.TabIndex = 17;
            // 
            // FormAntrenorDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAntrenorDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntrenorDB";
            this.Load += new System.EventHandler(this.FormAntrenorDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antrenor2BindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNrClienti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdaugaEditeaza;
        private System.Windows.Forms.TextBox tbPrenumeA;
        private System.Windows.Forms.TextBox tbNumeA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarCliientiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource antrenor2BindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAntrenori;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnGrafic;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ComboBox cbAntrenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxAntrenor;
        private System.Windows.Forms.Button btnAdaugaClienti;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}