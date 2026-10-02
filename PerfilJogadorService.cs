using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerProfile.App
{
    public class PerfilJogadorService
    {
        // Método que concatena nickname e código com #
        public string GerarTagUsuario(string nickname, string codigo)
        {
            return $"{nickname}#{codigo}";
        }

        // Método que soma XP das duas fases e adiciona bônus fixo de 100
        public int CalcularXPTotal(int xpFase1, int xpFase2)
        {
            return xpFase1 + xpFase2 + 100;
        }

        // Método que verifica se o jogador é elegível para ranked (nível >= 15)
        public bool EEligivelParaRanked(int nivelJogador)
        {
            return nivelJogador >= 15;
        }
    }
}
