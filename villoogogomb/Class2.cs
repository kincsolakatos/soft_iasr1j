using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villoogogomb
{
    internal class Szines : Button
    {
        public Szines()
        {
            MouseClick += Szines_MouseClick;
            Width = 20;
            Height = 20;
        }

        private void Szines_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor == Color.Turquoise)
                BackColor = SystemColors.ButtonFace;
            else
                BackColor = Color.Turquoise;
        }
    }
}
