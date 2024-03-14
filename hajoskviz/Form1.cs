using System.Diagnostics.Eventing.Reader;

namespace hajoskviz
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdes;
        int AktualisK = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesBetoltes();
            AktualisKerdes = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdes.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdes;
            KerdesMegjelenites(AktualisKerdes[AktualisK]);
        }

        private void G_Click(object? sender, EventArgs e)
        {
            AktualisK++;
        }

        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Válasz1;
            valaszGomb2.Text = kerdes.Válasz2;
            valaszGomb3.Text = kerdes.Válasz3;
            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }
        List<Kerdes> KerdesBetoltes()
        {
            List<Kerdes> Kerdesek = new List<Kerdes>();
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "--";
                string[] tomb = sor.Split("\t");
                if (tomb.Length != 7) continue;
                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1];
                k.Válasz1 = tomb[2];
                k.Válasz2 = tomb[3];
                k.Válasz3 = tomb[4];
                k.URL = tomb[5];
                int x = 0;
                int.TryParse(tomb[6], out x);
                k.HelyesVálasz = x;
                Kerdesek.Add(k);
            }
            sr.Close();
            return Kerdesek;
        }
    }
}