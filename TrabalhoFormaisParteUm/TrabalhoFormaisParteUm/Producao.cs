using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    class Producao {
        public string esquerdo { get; set; }
        public string direito { get; set; }

        public Producao(string esquerdo, string direito) {
            this.direito = direito;
            this.esquerdo = esquerdo;
        }

        public Producao() { }
    }
}
