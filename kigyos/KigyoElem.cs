using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyos
{
    internal class KigyoElem : PictureBox
    {
        public static int Meret = 20;
        public static int hossz = 5;
        public KigyoElem()
        {
            Width = KigyoElem.Meret;
            Height = KigyoElem.Meret;
        }
    }

    class Alma : KigyoElem
    {

        public Alma()
        {
             BackColor = Color.Red;
        }
    }
}
