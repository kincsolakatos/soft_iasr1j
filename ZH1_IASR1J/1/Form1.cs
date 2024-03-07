namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 1; i <= 10; i++)
            {
                Sor ujSor = new Sor();
                ujSor.Alap = 3;
                ujSor.Kitevo = i;
                ujSor.Eredmeny = (int)Math.Pow(3, i);
                sorok.Add(ujSor);
            }
            dataGridView1.DataSource = sorok;
        }
    }
}