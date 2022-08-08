using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PAW_PROJECT
{
    public partial class AdaugaClient : Form
    {
        List<Client> listaClienti=null;
        public AdaugaClient()
        {
            InitializeComponent();
            listaClienti = new List<Client>();
        }
        public AdaugaClient(List<Client>clienti)
        {
            InitializeComponent();
            listaClienti = clienti;
        }

        private void golireLista()
        {
            lvClienti.Items.Clear();
        }
        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            rbAbonamentPremium.Checked = false;
            rdAbonamentNormal.Checked = false;
            rdAbonamentStudent.Checked = false;
            dataNastere.Value = DateTime.Now;
        }
        private void btnCurata_Click(object sender, EventArgs e)
        {
            golireFormular();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {

            string nume = tbNume.Text;
            if (string.IsNullOrEmpty(nume) || (string.IsNullOrWhiteSpace(nume)) || (nume.Length < 3))
            {
                errNume.SetError(tbNume, "Numele trebuie sa aiba mai mult de 3 caractere!");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errNume.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            string nume = tbPrenume.Text;
            if (string.IsNullOrEmpty(nume) || (string.IsNullOrWhiteSpace(nume)) || (nume.Length < 3))
            {
                errNume.SetError(tbNume, "Numele trebuie sa aiba mai mult de 3 caractere!");
                e.Cancel = true;
            }

        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errPrenume.Clear();
        }

        #region CRUD
        //create
        private void btnAdauga_Click(object sender, EventArgs e)
        {


            bool valid = true;

            string nume = tbNume.Text;
            if (string.IsNullOrEmpty(nume) || (string.IsNullOrWhiteSpace(nume)) || (nume.Length < 3))
            {
                valid = false;
            }
            String prenume = tbPrenume.Text;
            if (string.IsNullOrEmpty(prenume) || (string.IsNullOrWhiteSpace(prenume)) || (prenume.Length < 3))
            {
                valid = false;
            }
            DateTime dtn = dataNastere.Value;
            if (DateTime.Compare(dtn, DateTime.Now) > 0)
            {
                valid = false;
            }


            if (valid)
            {
                //creare+afisare

                Client client = new Client();
                client.NumeClient = tbNume.Text;
                client.PrenumeClient = tbPrenume.Text;
                if (rbAbonamentPremium.Checked)
                    client.TipAbonament1 = tipAbonament.Abonament_premium;
                if (rdAbonamentNormal.Checked)
                    client.TipAbonament1 = tipAbonament.Abonament_normal;
                if (rdAbonamentStudent.Checked)
                    client.TipAbonament1 = tipAbonament.Abonament_Student;

                client.DateNasterii = dataNastere.Value;

                //adaugare list view

                listaClienti.Add(client);


                populeazaListView();


                golireFormular();
                //  MessageBox.Show("Instanta creata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        //read
        private void populeazaListView()
        {
            //curatare list view(UI)

            golireLista();

            //adaugare list view

            foreach (Client clientc in listaClienti)
            {
                //ListViewItem lvc = new ListViewItem();
                //lvClienti.Items.Add(lvc);
                ListViewItem item = new ListViewItem(clientc.NumeClient);
                item.SubItems.Add(clientc.PrenumeClient);
                item.SubItems.Add(clientc.TipAbonament1.ToString());
                item.SubItems.Add(clientc.DateNasterii.ToString());
                item.Tag = clientc;
                lvClienti.Items.Add(item);
            }
        }


        //update

        private void lvClienti_DoubleClick(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems[0] != null)
            {
                ListViewItem item = lvClienti.SelectedItems[0];
                int index = item.Index;
                Client c = listaClienti[index];
                FormularEditareClienti form = new FormularEditareClienti(c);
                form.ShowDialog();
                //  golireFormular();
                populeazaListView();
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            try
            {

                if (lvClienti.SelectedItems[0] != null)
                {
                    ListViewItem item = lvClienti.SelectedItems[0];
                    int index = item.Index;
                    Client c = listaClienti[index];
                    FormularEditareClienti form = new FormularEditareClienti(c);
                    form.ShowDialog();
                    //  golireFormular();
                    populeazaListView();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Selecteaza o inregistrare!");
            }

        }



        //delete
        private void btnStergere_Click(object sender, EventArgs e)
        {
            try {
                if (lvClienti.SelectedItems[0] != null)
                {

                    if (DialogResult.Yes == MessageBox.Show("Doresti sa stergi aceasta inregistrare?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //ListViewItem item = lvClienti.SelectedItems[0];
                        //int index = item.Index;
                        //Client client = listaClienti[index];
                        Client client = lvClienti.SelectedItems[0].Tag as Client;

                        listaClienti.Remove(client);

                        populeazaListView();
                    }

                }
            }
      catch(Exception ex)
            {
                MessageBox.Show("Trebuie selectata o inregistrare pentru stergere.");
            }
        }
        #endregion

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStergere_Click(sender, e);
        }

        private void lvClienti_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        #region SERIALIZARE/DESERIALIZARE/FISIERE TEXT
        private void seializareBinara_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("binary.dat",FileMode.Create);

            formatter.Serialize(stream ,listaClienti);

            stream.Close();
            MessageBox.Show("Fisierul binar a fost creat cu succes!");
        }
        private void deserializareBINARA_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Text files(*.txt)|*.txt|Binary files(*.dat)|*.dat|All files(*.*)|*.*";
            ofd.FilterIndex = 2;//incepe de la 1 numaratoare indecsilor

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                listaClienti = formatter.Deserialize(stream) as List<Client>;
                stream.Close();
                populeazaListView();
            }

        }

        private void serializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            FileStream stream = File.Create("lista.xml");
            serializer.Serialize(stream, listaClienti);
            stream.Close();
            MessageBox.Show("Fisierul XML a fost creat cu succes!");
        }

        private void deserializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            try
            {
                FileStream stream = File.OpenRead("lista.xml");
                listaClienti = serializer.Deserialize(stream) as List<Client>;
                stream.Close();
                populeazaListView();
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Selecteaza fisierul binar pentru deserializare";
            sfd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            sfd.FilterIndex = 1;//incepe de la 1 numaratoare indecsilor

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.WriteLine("Nume   Prenume   Tip abonament   Data nastere");
                foreach(Client c in listaClienti)
                {
                    writer.WriteLine(c.numeClient + "," + c.prenumeClient + "," + c.TipAbonament + ","+c.dateNasterii.ToString());

                }
                writer.Close();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul binar pentru deserializare";
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            ofd.FilterIndex = 1;//incepe de la 1 numaratoare indecsilor

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                listaClienti.Clear();
                StreamReader read = new StreamReader(ofd.FileName);
                String linie = read.ReadLine();//ca sa citeasca capul de fisier introdus de noi

                while (( linie=read.ReadLine())!=null)
                {
                    try
                    {
                        String[] tokens = linie.Split(',');
                        Client c = new Client();
                        c.numeClient = tokens[0];
                        c.prenumeClient = tokens[1];
                        if (tokens[2] == "Abonament_normal")
                            c.TipAbonament = tipAbonament.Abonament_normal;
                        else if (tokens[2] == "Abonament_premium ")
                            c.TipAbonament = tipAbonament.Abonament_premium;
                        else c.TipAbonament = tipAbonament.Abonament_Student;
                        c.dateNasterii = DateTime.Parse(tokens[3]);

                        listaClienti.Add(c);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                read.Close();
                populeazaListView();
            }
        }
        private void serializareJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            FileStream stream = File.Create("lista.json");
            TextWriter writer = new StreamWriter(stream);

            serializer.Serialize(writer, listaClienti);

            writer.Close();
            stream.Close();
        }

        private void deserializareJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            FileStream stream = File.OpenRead("lista.json");
            TextReader reader = new StreamReader(stream);

          listaClienti=  serializer.Deserialize(reader, typeof(List<Client>)) as List<Client>;

            reader.Close();
            stream.Close();

            populeazaListView();

        }



        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

