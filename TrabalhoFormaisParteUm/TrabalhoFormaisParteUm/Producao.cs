using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    class Producao {
        public string esquerdo { get; set; }
        public List<string> direitos { get; set; }

        public Producao(string esquerdo, string direito) {
            this.direitos = new List<string>();
            this.direitos.Add(direito);
            this.esquerdo = esquerdo;
        }

        public Producao() {
            direitos = new List<string>();
        }
    }
}
