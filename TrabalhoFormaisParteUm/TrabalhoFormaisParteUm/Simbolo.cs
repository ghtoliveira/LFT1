using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    public enum TIPO_SIMBOLO { TERMINAL, NAOTERMINAL }

    class Simbolo {
        public string simbolo { get; set; }
        public TIPO_SIMBOLO tipo { get; set; }
        
    }
}
