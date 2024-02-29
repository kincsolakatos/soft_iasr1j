namespace villoogogomb
{
    public partial class Form1 : Form
    {
        int m = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Szamolog b = new Szamolog();
                    b.Left = j * Szamolog.me;
                    b.Top = i * Szamolog.me;
                    Controls.Add(b);
                }
            }
        }
    }
}