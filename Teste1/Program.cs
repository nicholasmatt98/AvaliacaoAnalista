/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência alfanumérica:");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Nenhum valor foi informado.");
                return;
            }

            string resultado = RemoverDuplicadosProximos(entrada);
            Console.WriteLine($"Resultado: {resultado}");
        }

        // Percorre caractere por caractere e só mantém quando é diferente do anterior.
        static string RemoverDuplicadosProximos(string texto)
        {
            string resultado = string.Empty;

            foreach (char caractere in texto)
            {
                if (resultado.Length == 0 || resultado[resultado.Length - 1] != caractere)
                {
                    resultado += caractere;
                }
            }

            return resultado;
        }
    }
}
