using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _1
{
    public partial class Form1 : Form
    {
        public BindingList<Ital> italok = new BindingList<Ital>();
        public Form1()
        {
            InitializeComponent();
            bindingSource1.DataSource = italok;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader("italok.txt");
                var csv = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<Ital>();
                foreach (var item in tomb)
                    italok.Add(item);
                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMentes_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(italok);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
                return;
            if (MessageBox.Show("Biztos torolned a kijelolt sort?", "Megerosites szukseges!", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            bindingSource1.RemoveCurrent();
        }
        private void buttonUjSor_Click(object sender, EventArgs e)
        {
            FormUjSor formUjSor = new FormUjSor();
            if (formUjSor.ShowDialog() == DialogResult.OK)
                italok.Add(formUjSor.UjItal);
        }
        private void buttonErdekessegek_Click(object sender, EventArgs e)
        {
            var nepszeruitalokszama = italok.Count(v => v.Nepszeru == true);
            var legmagasabbalkoholtartalom = italok.OrderBy(v => v.Alkoholtartalom).LastOrDefault();
            MessageBox.Show($"A listaban {nepszeruitalokszama} nepszeru ital szerepel. Erdemes a {legmagasabbalkoholtartalom.Nev} italt valasztani, ennek alkoholtartalma pedig {legmagasabbalkoholtartalom.Alkoholtartalom}");
        }
    }
}