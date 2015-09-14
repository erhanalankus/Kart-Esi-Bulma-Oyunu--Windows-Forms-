using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheSame.WithResourcesFolder
{
    class Kart:PictureBox
    {        
        public string ResimAdresi { get; set; }

        internal void Ac()
        {
            Image = Image.FromFile(Application.StartupPath + ResimAdresi);
            acikMiyim = true;
        }

        internal void Kapat()
        {
            Image = Properties.Resources.que;
            acikMiyim = false;
        }

        bool acikMiyim;
        internal bool KapaliMi()
        {
            return !acikMiyim;
        }
    }
}
