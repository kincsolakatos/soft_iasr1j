using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace csv
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> CountryList = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = CountryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void megnyitas_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb) CountryList.Add(item);
            sr.Close();
        }
        private void torles_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }
        private void szerkesztes_Click(object sender, EventArgs e)
        {
            FormCountryEdit fce = new FormCountryEdit();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }
        private void save_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(CountryList);
            }
        }
    }
}