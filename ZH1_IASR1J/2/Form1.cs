namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int szam = int.Parse(textBox1.Text);
            for (int i = 0; i < szam; i++)
            {
                LikeButton like = new LikeButton();
                like.Top = i * 30;
                Controls.Add(like);
            }
        }
    }
}