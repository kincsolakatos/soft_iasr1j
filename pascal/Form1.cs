namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    Button b = new Button();
                    b.Height = m;
                    b.Width = m;
                    b.Top = sor * m;
                    b.Left = oszlop * m;
                    Controls.Add(b);
                    int x = faktorialis(sor) / (faktorialis(oszlop) * faktorialis(sor - oszlop));
                    b.Text = x.ToString();
                }
            }
        }

        int faktorialis (int n)
        {
            if (n == 0) return 1;
            return n * faktorialis (n - 1);
        }
    }
}