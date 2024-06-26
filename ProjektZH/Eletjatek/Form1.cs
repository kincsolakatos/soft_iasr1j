namespace Eletjatek
{
    public partial class Form1 : Form
    {
        private bool[,] palya;
        private bool[,] ujPalya;
        private int sorok;
        private int oszlopok;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            sorok = (int)numericUpDownSorok.Value;
            oszlopok = (int)numericUpDownOszlopok.Value;
            palya = new bool[sorok, oszlopok];
            ujPalya = new bool[sorok, oszlopok];
            int eloSejtek = (int)numericUpDownEloSejtek.Value;
            for (int i = 0; i < eloSejtek; i++)
            {
                int sor = random.Next(sorok);
                int oszlop = random.Next(oszlopok);
                palya[sor, oszlop] = true;
            }
            panel.Invalidate();
            timer.Start();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            float cellWidth = (float)panel.Width / oszlopok;
            float cellHeight = (float)panel.Height / sorok;
            for (int i = 0; i < sorok; i++) 
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    RectangleF cell = new RectangleF(j * cellWidth, i * cellHeight, cellWidth, cellHeight);
                    if (palya[i, j])
                    {
                        e.Graphics.FillRectangle(Brushes.Black, cell);
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < sorok; ++i)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    int szomszedok = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            if (k == 0 && l == 0)
                            {
                                continue;
                            }
                            int ujSor = i + k;
                            int ujOszlop = j + l;
                            if (ujSor >= 0 && ujOszlop >= 0 && ujSor < sorok && ujOszlop < oszlopok)
                            {
                                szomszedok += palya[ujSor, ujOszlop] ? 1 : 0;
                            }
                        }
                    }
                    if (palya[i, j])
                    {
                        ujPalya[i, j] = szomszedok == 2 || szomszedok == 3;
                    }
                    else
                    {
                        ujPalya[i, j] = szomszedok == 3;
                    }
                }
            }
            palya = ujPalya;
            panel.Invalidate();
        }
    }
}