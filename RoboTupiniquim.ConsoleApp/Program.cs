namespace RoboTupiniquim.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Robo robson = new Robo();

        string posicaoInicial = "1 2 N";
        string comando = "EMEMEMEMM";

        string[] coordenadasIniciais = posicaoInicial.Split(' ');

        robson.posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
        robson.posicaoY = Convert.ToInt32(coordenadasIniciais[1]);
        robson.direcao = Convert.ToChar(coordenadasIniciais[2]);

        char[] instrucoes = comando.ToCharArray();

        robson.Explorar(instrucoes);

        robson.ExibirCoordenadas();

        string posicaoInicialDois = "3 3 L";
        string comandoDois = "MMDMMDMDDM";

        Robo bender = new Robo();

        string[] coordenadasIniciaisDois = posicaoInicialDois.Split(' ');

        bender.posicaoX = Convert.ToInt32(coordenadasIniciaisDois[0]);
        bender.posicaoY = Convert.ToInt32(coordenadasIniciaisDois[1]);
        bender.direcao = Convert.ToChar(coordenadasIniciaisDois[2]);

        char[] instrucoesDois = comandoDois.ToCharArray();

        bender.Explorar(instrucoesDois);

        bender.ExibirCoordenadas();

        Console.ReadLine();
    }
}
