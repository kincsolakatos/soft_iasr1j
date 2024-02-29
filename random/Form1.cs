namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                Button b = new Button();
                b.Height = r.Next(1, ClientRectangle.Height);
                b.Width = r.Next(1, ClientRectangle.Width);
                b.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
        }
    }
}