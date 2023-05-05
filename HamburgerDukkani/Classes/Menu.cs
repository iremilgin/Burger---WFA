using HamburgerDukkani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerDukkani.Classes
{
    public class Menu : Urun
    {
        public override string ToString()
        {
            return $"{this.Adi} Menu";
        }
    }
}
