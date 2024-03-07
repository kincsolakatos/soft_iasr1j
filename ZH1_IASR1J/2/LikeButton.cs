using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class LikeButton : Label
    {
        int szam = 0;
        public LikeButton()
        {
            AutoSize = true;
            BackColor = Color.Gray;
            Text = "☆ ☆ ☆ ☆ ☆";
            MouseClick += LikeButton_MouseClick;
        }

        private void LikeButton_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            if (szam == 0) Text = "☆ ☆ ☆ ☆ ☆";
            if (szam == 1) Text = "★ ☆ ☆ ☆ ☆";
            if (szam == 2) Text = "★ ★ ☆ ☆ ☆";
            if (szam == 3) Text = "★ ★ ★ ☆ ☆";
            if (szam == 4) Text = "★ ★ ★ ★ ☆";
            if (szam == 5)
            {
                Text = "★ ★ ★ ★ ★";
                szam = -1;
            }
        }
    }
}
