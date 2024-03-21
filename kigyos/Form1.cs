namespace kigyos
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int iranyX = 1;
        int iranyY;
        int lepesszam;
        List<KigyoElem> kigyo = new List<KigyoElem>();
        Alma alma;
        PictureBox mereg;
        public Form1()
        {
            InitializeComponent();
        }
Random r = new Random();
        public void Form1_Load(object sender, EventArgs e)
        {

            KeyDown += Form1_KeyDown;
            
            int almaX = r.Next(1, ClientRectangle.Width / KigyoElem.Meret) * KigyoElem.Meret;
            int almaY = r.Next(1, ClientRectangle.Height / KigyoElem.Meret) * KigyoElem.Meret;
            int meregX = r.Next(1, ClientRectangle.Width / KigyoElem.Meret) * KigyoElem.Meret;
            int meregY = r.Next(1, ClientRectangle.Height / KigyoElem.Meret) * KigyoElem.Meret;
            alma = new ();
            alma.Width = KigyoElem.Meret;
            alma.Height = KigyoElem.Meret;
            alma.Top = almaY;
            alma.Left = almaX;
            alma.BackColor = Color.Red;
            Controls.Add(alma);
            mereg = new PictureBox();
            mereg.Width = KigyoElem.Meret;
            mereg.Height = KigyoElem.Meret;
            mereg.Top = meregY;
            mereg.Left = meregX;
            mereg.BackColor = Color.Green;
            Controls.Add(mereg);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                iranyY = -1;
                iranyX = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                iranyY = 1;
                iranyX = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                iranyY = 0;
                iranyX = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                iranyY = 0;
                iranyX = 1;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;
            fejX += iranyX * KigyoElem.Meret;
            fejY += iranyY * KigyoElem.Meret;
            foreach (object item in kigyo)
            {

                if (item is KigyoElem)
                {
                    KigyoElem ke = (KigyoElem)item;
                    if (ke.Top == fejY && ke.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                


            }

            if(fejX==alma.Left)

            KigyoElem ke = new KigyoElem();
            ke.Top = fejY;
            ke.Left = fejX;
            kigyo.Add(ke);
            Controls.Add(ke);
            if (kigyo.Count > KigyoElem.hossz)
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }
            if (lepesszam % 2 == 0)
                ke.BackColor = Color.Black;
            else
                ke.BackColor = Color.Orange;
        }
    }
}