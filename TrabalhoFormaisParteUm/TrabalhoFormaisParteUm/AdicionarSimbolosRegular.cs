using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrabalhoFormaisParteUm {
    class AdicionarSimbolosRegular {

        public static void adicionarNaoTerminal(string simbolo) {
            if (String.IsNullOrEmpty(simbolo)) {
                MessageBox.Show("Símbolos não podem estar vazios.", "Verifique seu símbolo");
                return;
            }
            if (simbolo.Length > 1) {
                MessageBox.Show("Símbolos não terminais devem conter apenas uma letra.", "Verifique seu símbolo");
                return;
            } else if (Regex.Matches(simbolo, @"[A-Z]").Count == 0) {
                MessageBox.Show("Símbolos não terminais devem conter apenas letras maiúsculas.", "Verifique seu símbolo");
                return;
            } else {
                bool adicionado = Gramatica.adicionarNaoTerminal(simbolo);
                if (adicionado) {
                    MessageBox.Show("Símbolos não terminal adicionado com sucesso!", "Símbolo adicionado");
                } else {
                    MessageBox.Show("Símbolos já adicionado! Tente novamente.", "Verifique seu símbolo");
                }
                return;
            }
        }


        ///TODO: Consertar o símbolo vazio (&) não aparecendo no label de produções por alguma treta malígna
        public static void adicionarTerminal(string simbolo, bool regular) {
            if (String.IsNullOrEmpty(simbolo)) {
                MessageBox.Show("Símbolos não podem estar vazios.", "Verifique seu símbolo");
                return;
            }
            if (simbolo.Length > 1) {
                MessageBox.Show("Símbolos terminais devem conter apenas uma letra ou dígito.", "Verifique seu símbolo");
                return;
            } else if (regular && Regex.Matches(simbolo[0].ToString(), @"[0-9a-z&]").Count == 0) {
                MessageBox.Show("Símbolos terminais devem conter apenas letras minúsculas ou digitos.", "Verifique seu símbolo");

                return;
            } else if (!regular && Regex.Matches(simbolo[0].ToString(), @"[0-9a-z]").Count == 0) {
                MessageBox.Show("Símbolos terminais devem conter apenas letras minúsculas ou digitos e não devem conter sentença vazia(&).", "Verifique seu símbolo");
            } else {
                bool adicionado = Gramatica.adicionarTerminal(simbolo);
                if (adicionado) {
                    MessageBox.Show("Símbolos terminal adicionado com sucesso!", "Símbolo adicionado");
                } else {
                    MessageBox.Show("Símbolos já adicionado! Tente novamente.", "Verifique seu símbolo");
                }
                return;
            }
        }
    }
}
