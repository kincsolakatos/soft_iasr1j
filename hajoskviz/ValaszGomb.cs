using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajoskviz
{
    internal class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
        }
    }
}
