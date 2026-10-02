# Gamer Profile - Testes com xUnit

Este projeto é um serviço de cadastro de jogadores (Gamer Profile) desenvolvido em .NET 10. O objetivo principal do sistema é gerenciar informações de perfil de jogadores, como geração de tags, cálculo de experiência (XP) e verificação de elegibilidade para partidas ranqueadas.

## Estrutura de Testes Unitários

O projeto utiliza o framework **xUnit** para garantir a qualidade do código de produção. Foram implementados três tipos principais de testes:

1. **Testes de String (`Assert.Equal`)**: Valida se o método `GerarTagUsuario` formata corretamente a tag do jogador unindo o nickname e um código numérico com uma hashtag (`#`).
2. **Testes de Inteiro (`Assert.Equal`)**: Valida se o método `CalcularXPTotal` realiza a soma correta da pontuação de duas fases do jogo e aplica o bônus fixo de 100 pontos de forma adequada.
3. **Testes Booleanos (`Assert.True` e `Assert.False`)**: Valida a regra de negócios do método `EEligivelParaRanked`, garantindo que apenas jogadores no nível 15 ou superior possam acessar as partidas ranqueadas.

## Como executar os testes

Certifique-se de ter o SDK do .NET 10 (ou superior) instalado na sua máquina.

1. Clone o repositório:
   ```bash
   git clone [https://github.com/SEU-USUARIO/gamer-profile-xunit.git](https://github.com/SEU-USUARIO/gamer-profile-xunit.git)
