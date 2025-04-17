namespace RoboTupiniquim.ConsoleApp;

public static class Robo
{
    public static int posicaoX;
    public static int posicaoY;
    public static char direcao;

    public static void Explorar(char[] instrucoes)
    {
        for (int i = 0; i < instrucoes.Length; i++)
        {
            char instrucaoAtual = instrucoes[i];

            if (instrucaoAtual == 'E')
                VirarEsquerda();

            else if (instrucaoAtual == 'D')
                VirarDireita();

            else if (instrucaoAtual == 'M')
                Mover();
        }
    }

    public static void VirarEsquerda()
    {
        if (direcao == 'N')
            direcao = 'O';

        else if (direcao == 'O')
            direcao = 'S';

        else if (direcao == 'S')
            direcao = 'L';

        else if (direcao == 'L')
            direcao = 'N';
    }

    public static void VirarDireita()
    {
        if (direcao == 'N')
            direcao = 'L';

        else if (direcao == 'L')
            direcao = 'S';

        else if (direcao == 'S')
            direcao = 'O';

        else if (direcao == 'O')
            direcao = 'N';
    }

    public static void Mover()
    {
        if (direcao == 'N')
            posicaoY++;

        else if (direcao == 'S')
            posicaoY--;

        else if (direcao == 'O')
            posicaoX--;

        else if (direcao == 'L')
            posicaoX++;
    }

    public static void ExibirCoordenadas()
    {
        Console.WriteLine($"Posição final do Robô: {posicaoX} {posicaoY} {direcao}");
        Console.Read();
    }
}
