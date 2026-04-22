using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyuttesek.Models
{
    public partial class Albumok
    {
        public int sorszam { get; set; }
        public string egyuttes { get; set; }
        public string album { get; set; }
        public int kiadas_eve { get; set; }
        public int hossz { get; set; }
        public int ar { get; set; }
    }
}
