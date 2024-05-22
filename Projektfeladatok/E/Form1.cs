namespace E {
    public partial class Form1 : Form {
        private bool [,] p, uP;
        private int sk, ok;
        Random r = new Random ();
        public Form1 () {
            InitializeComponent ();
            t.Interval = 100; }
        private void Form1_Load (object sender, EventArgs e) { }
        private void sB_Click (object sender, EventArgs e) {
            sk = (int) nUDS.Value;
            ok = (int) nUDO.Value;
            p = new bool [sk, ok];
            uP = new bool [sk, ok];
            int eSSz = (int) nUDES.Value;
            for (int i = 0; i < eSSz; i++) {
                int s = r.Next (sk), o = r.Next (ok);
                p [s, o] = true; }
            p1.Invalidate ();
            t.Start (); }
        private void p1_Paint (object sender, PaintEventArgs e) {
            float cW = (float) p1.Width / ok, cH = (float) p1.Height / sk;
            for (int i = 0; i < sk; i++) for (int j = 0; j < ok; j++) {
                RectangleF c = new RectangleF (j * cW, i * cH, cW, cH);
                if (p [i, j]) e.Graphics.FillRectangle (Brushes.Black, c); } }
        private void t_Tick (object sender, EventArgs e) {
            for (int i = 0; i < sk; i++) for (int j = 0; j < ok; j++) {
                int sz = 0;
                for (int k = -1; k <= 1; k++) for (int l = -1; l <= 1; l++) {
                    if (k == 0 && l == 0) continue;
                    int uS = i + k, uO = j + l;
                    if (uS >= 0 && uO >= 0 && uS < sk && uO < ok) sz += p [uS, uO] ? 1 : 0; }
                if (p [i, j]) uP [i, j] = sz == 2 || sz == 3;
                else uP [i, j] = sz == 3; }
            p = uP;
            p1.Invalidate (); } } }