using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villoogogomb
{
    internal class Szamolog : Button
    {
        public static int me = 20;
        public int szam = 1;
        public Szamolog()
        {
            Width = 20;
            Height = 20;
            MouseClick += Szamolog_MouseClick;
        }

        private void Szamolog_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam > 5)
                szam = 1;
            Text = szam.ToString();
            szam++;
        }
    }
}
