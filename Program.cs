namespace Projeto___calculadora_de_RPM_para_furadeira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            double[] velcorte = { 25, 18.5, 10, 12.5, 25, 17.5, 50, 40, 25, 35, 65, 40 };
            int usuario;
            double broca;
            int RPM;
            string resposta;

            // Mostra o menu na tela
            do
            {
                Menu01();

                // Lê a opção do usuário de forma segura (impede letras e enter vazio)
                // Também garante que o número digitado esteja entre 1 e 12
                while (!int.TryParse(Console.ReadLine(), out usuario) || usuario < 1 || usuario > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida! Digite um número de 1 a 12:");
                    Console.ResetColor();
                }

                Console.Clear();
                Console.WriteLine("Qual o diâmetro da broca (aço rápido)? (Valor em Milímetros)");

                // Lê o diâmetro da broca de forma segura (aceita números com vírgula e impede <= 0)
                while (!double.TryParse(Console.ReadLine(), out broca) || broca <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Diâmetro inválida! Digite um número maior que zero (Ex: 8 ou 10,5):");
                    Console.ResetColor();
                }

                RPM = (int)Math.Round((velcorte[usuario - 1] * 1000) / (broca * Math.PI));

                Console.Clear();
                Console.WriteLine("|------------------------------------------------------|");
                Console.WriteLine($"  A velocidade ideal para furar o material é: {RPM} RPM ");
                Console.WriteLine("|------------------------------------------------------|\n");

                Console.WriteLine("Deseja calcular novamente? [S para sim /N para não]");
                resposta = Console.ReadLine().ToUpper();
            } while (resposta == "S");

        }

        static void Menu01()
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|SimpleHole - Faça furos certos|");
            Console.WriteLine("|Feito por: Christian Daniel   |");
            Console.WriteLine("|GitHub:@Christian-THEDEV      |");
            Console.WriteLine("|------------------------------|\n");
            Console.WriteLine("Digite o número correspondente ao material que deseja furar:");
            Console.WriteLine("1 - Aço baixo carbono");
            Console.WriteLine("2 - Aço médio carbono");
            Console.WriteLine("3 - Aço duro");
            Console.WriteLine("4 - Aço inoxidável");
            Console.WriteLine("5 - Ferro fundido cinzento");
            Console.WriteLine("6 - Ferro fundido nodular");
            Console.WriteLine("7 - Alumínio");
            Console.WriteLine("8 - Latão");
            Console.WriteLine("9 - Cobre");
            Console.WriteLine("10 - Plásticos");
            Console.WriteLine("11 - Madeira Macia");
            Console.WriteLine("12 - Madeira dura/MDF\n");
            Console.Write("Sua opção: "); // Guia visual para o usuário saber onde digitar
        }
    }
}
