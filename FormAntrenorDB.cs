using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaHistograma;
namespace PAW_PROJECT
{
    public partial class FormAntrenorDB : Form
    {
        HRApplicationContext ctx = new HRApplicationContext();
        List<Client> clienti = new List<Client>();
        public FormAntrenorDB()
        {
            InitializeComponent();
        }

        private void FormAntrenorDB_Load(object sender, EventArgs e)
        {
            antrenor2BindingSource.DataSource = ctx.Antrenori2.ToList();
        }

        private void btnAdaugaEditeaza_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                //edit
                 Antrenor2 antrenor = antrenor2BindingSource.Current as Antrenor2;
               // Antrenor2 antrenor=null;
                if (tbNumeA.Text != "")
                    antrenor.Nume = tbNumeA.Text;
                if (tbPrenumeA.Text != "")
                    antrenor.Prenume = tbPrenumeA.Text;
                try
                {
                    if (tbNrClienti.Text.All(char.IsDigit) && tbNrClienti.Text != "")
                        antrenor.numarCliienti = clienti.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                antrenor.Clienti = clienti;
                antrenor.Manager = cbAntrenor.Text;

                ctx.Antrenori2.Update(antrenor);
            }
            else
            {
                //adaugare
                Antrenor2 antrenor = new Antrenor2();
                if (tbNumeA.Text != "")
                    antrenor.Nume = tbNumeA.Text;
                if (tbPrenumeA.Text != "")
                    antrenor.Prenume = tbPrenumeA.Text;
                try
                {
                    if (tbNrClienti.Text.All(char.IsDigit) && tbNrClienti.Text != "")
                        antrenor.numarCliienti = clienti.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                antrenor.Manager = cbAntrenor.Text;
                antrenor.Clienti = clienti;
                ctx.Antrenori2.Add(antrenor);

            }
            ctx.SaveChanges();

           antrenor2BindingSource.DataSource = ctx.Antrenori2.ToList();
            //curatare formular
            tbNrClienti.Clear();
            tbNumeA.Clear();
            tbPrenumeA.Clear();
            statusStripLabel.Text = "Numar clienti: 0";
            listboxAntrenor.DataSource = null;
            cbAntrenor.DataSource = null;
            clienti = new List<Client>();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi inregistrarea?", "Sterge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctx.Antrenori2.Remove(antrenor2BindingSource.Current as Antrenor2);

                    ctx.SaveChanges();

                    antrenor2BindingSource.DataSource = ctx.Antrenori2.ToList();
                }
            }
            
        }

        private void toolStripBtnAntrenori_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugaClient fclient = new AdaugaClient();
            fclient.ShowDialog();

            this.Close();
        }

        #region Printare
        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDoc;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {

                printDoc.DefaultPageSettings = pageSetupDialog.PageSettings;

                printPreviewDialog.Document = printDoc;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;//referinta la graphics
            Font font = new Font("Arial",20);
            Brush brush = Brushes.DarkRed;
            Pen pen = new Pen(brush);


            PageSettings pageSettings = printDoc.DefaultPageSettings;
            var latime = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            var lungime= pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;

            if (pageSettings.Landscape)
            {
                var temp = lungime;
                lungime = latime;
                latime = temp;
            }

            int cellWidth = latime / 2;
            int cellHight = 40;
            int x=pageSettings.Margins.Left;
            int y=100;

            graphics.DrawString("Lista antrenori", font, brush, latime / 3, y);

            //desenare celule cap tabel
            y += 100;
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHight); 
            graphics.DrawRectangle(pen, x+cellWidth,y, cellWidth, cellHight);

            //desenare continut cap tabel
            graphics.DrawString("Nume", font, brush, x, y);
            graphics.DrawString("Nr. clienti", font, brush, x+cellWidth, y);


            y += cellHight;
            List<Antrenor2> antrenori = ctx.Antrenori2.ToList();

            foreach(Antrenor2 a in antrenori)
            {
                //desenare celule
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHight);

                //desenare continut
                graphics.DrawString(a.Nume, font, brush, x, y);
                graphics.DrawString(a.numarCliienti.ToString(), font, brush, x + cellWidth, y);
                y += cellHight;
            }
        }

        #endregion

        private void btnAdaugaClienti_Click(object sender, EventArgs e)
        {
            AdaugaClient formClient = new AdaugaClient(clienti);

            if (formClient.ShowDialog() == DialogResult.Cancel)
            {
                int i = 0;
                String[] numes = new string[clienti.Count];
                foreach(Client c in clienti)
                {
                    numes[i] = c.NumeClient;
                    i++;
                }

                //data binding
                listboxAntrenor.DataSource = numes;
                cbAntrenor.DataSource = numes;

                tbNrClienti.Text =clienti.Count.ToString();
                statusStripLabel.Text = "Numar clienti" + clienti.Count;
                
            }
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Antrenor2 antrenor = antrenor2BindingSource.Current as Antrenor2;
            tbNumeA.Text = antrenor.Nume;
            tbPrenumeA.Text = antrenor.Prenume;
            tbNrClienti.Text = antrenor.numarCliienti.ToString();

            statusStripLabel.Text = "Numar clienti" + antrenor.numarCliienti;
       

           
            clienti = ctx.Clienti.Where(each=>each.AntrenoriId==antrenor.Id).ToList();
            int i = 0;
            String[] numes = new string[clienti.Count];
            foreach (Client c in clienti)
            {
                numes[i] = c.NumeClient;
                i++;
            }

            //data binding
            listboxAntrenor.DataSource = numes;
            cbAntrenor.DataSource = numes;


            cbAntrenor.Text = antrenor.Nume;
            //  cbAntrenor.Text = antrenor.Manager;


        }

        private void toolStripBtnGrafic_Click(object sender, EventArgs e)
        {
            ColoanaHistograma[] coloane = new ColoanaHistograma[clienti.Count];

            int index = 0;
            foreach (Client p in clienti)
            {
                coloane[index] = new ColoanaHistograma(p.NumeClient, (DateTime)p.DateNasterii, "red");
                index++;
            }

            Clipboard.SetData("ColoanaHistograma", coloane);

            Histograma histograma = new Histograma();
            histograma.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
