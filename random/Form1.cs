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
                int w = r.Next(1, ClientRectangle.Height);
                int h = r.Next(1, ClientRectangle.Height);
                b.Height = h;
                b.Width = w;
                b.Top = r.Next(1, ClientRectangle.Height - h);
                b.Left = r.Next(1, ClientRectangle.Width - w);
                b.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                Controls.Add(b);
            }
        }
    }
}