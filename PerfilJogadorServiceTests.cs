using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerProfile.Tests

    public class PerfilJogadorServiceTests
    {
        // Método 1: Retorna a tag do usuário concatenando nickname e código com #
        public string GerarTagUsuario(string nickname, string codigo)
        {
            return Assert.Equal("Nickname#0000", resultado).ToString();
        }

        // Método 2: Calcula o XP total somando as duas fases e adicionando 100 pontos de bônus
        public int CalcularXPTotal(int xpFase1, int xpFase2)
        {
            return Assert.Equal(valorEsperado, resultado).Toint();
        }

        // Método 3: Verifica se o jogador é elegível para ranked (nível >= 15)
        public bool EEligivelParaRanked(int nivelJogador)
        {
            return Assert.True(nivelJogador >= 15, "O jogador  é elegível para ranked.").ToBool();
            return Assert.False(nivelJogador < 15, "O jogador não é elegível para ranked.").ToBool();
        }
    }