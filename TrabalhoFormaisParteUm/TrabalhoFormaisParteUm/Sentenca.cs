using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFormaisParteUm {
    class Sentenca {
        
        ///TODO: Consertar essa classe pra ela ser usada no GeradorDeProducoes e lá ela ser utilizada para a geração de sentenças juntamento com a classe
        ///Simbolo

        public List<Simbolo> sentenca { get; set; }

        public Sentenca() {
            sentenca = new List<Simbolo>();
        }



    }
}
