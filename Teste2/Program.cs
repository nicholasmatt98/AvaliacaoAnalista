/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de repetições (número inteiro entre 1 e 19):");
            string entrada = Console.ReadLine();

            int quantidade;
            if (!int.TryParse(entrada, out quantidade) || quantidade <= 0 || quantidade >= 20)
            {
                Console.WriteLine("Valor inválido. Digite um número inteiro, positivo, maior que 0 e menor que 20.");
                return;
            }

            List<int> sequencia = GerarFibonacci(quantidade);
            Console.WriteLine("Sequência de Fibonacci: " + string.Join(", ", sequencia));
        }

        static List<int> GerarFibonacci(int quantidade)
        {
            List<int> sequencia = new List<int>();

            int anterior = 0;
            int atual = 1;

            for (int i = 0; i < quantidade; i++)
            {
                sequencia.Add(atual);

                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            return sequencia;
        }
    }
}
