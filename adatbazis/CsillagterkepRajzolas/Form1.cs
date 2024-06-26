using CsillagterkepRajzolas.Models;

namespace CsillagterkepRajzolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Pen toll = new Pen(Color.Fuchsia, 1);
            Brush brush = new SolidBrush(Color.White);
            HajosContext context = new HajosContext();
            var stars =
            (
                from s
                in context.StarData
                select new
                {
                    s.Hip,
                    s.X,
                    s.Y,
                    s.Magnitude
                }
            ).ToList();
            double nagyitas = 200;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;
            g.Clear(Color.Black);
            foreach (var star in stars)
            {
                if (star.Magnitude > 15) continue;
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;
                float x = (float)(star.X * nagyitas + cx);
                float y = (float)(star.Y * nagyitas + cy);
                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);
                g.FillEllipse(brush, x, y, (float)size, (float)size);
            }
            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {
                var star1 =
                (
                    from star
                    in stars
                    where star.Hip == line.Star1
                    select star
                ).FirstOrDefault();
                var star2 =
                (
                    from star
                    in stars
                    where star.Hip == line.Star2
                    select star
                ).FirstOrDefault();
                if (star1 == null || star2 == null) continue;
                float x1 = (float)(star1.X * nagyitas + cx);
                float y1 = (float)(star1.Y * nagyitas + cy);
                float x2 = (float)(star2.X * nagyitas + cx);
                float y2 = (float)(star2.Y * nagyitas + cy);
                g.DrawLine(toll, x1, y1, x2, y2);
            }
        }
    }
}