/*Módulos (Pacotes)*/
using System; /*Manipular o sistema operacional do usuario*/
using System.Collections.Generic;
using System.Linq; /*Manipula os dados*/
using System.Text; /*Manipula texto*/
using System.Threading.Tasks; /*Manipula o processamento*/
using System.IO; /*Manipula arquivos*/
using System.Net; /*Manipula rede*/

/*Programa começa aqui*/
namespace HelloWorld1
{
    internal class Program /*Ignorar ate chegar em orientação a objetos*/
    { /*Início do programa*/
        static void Main(string[] args) /*Função principal.*/
        { /*Tudo aqui dentro executa primeiro ao iniciar o programa.*/

            // Int - Inteiro
            // Float - Ponto Flutuante | Double e Decimal
            // Bool - Booleano
            // String - Texto usa ""
            // Char - 'a' (caractere unico)

            var nome = "Yan";
            int minhaIdade = 25;
            float mediaCarro = 6.9f;
            char notaEscola = 'A';
            bool verdade = false;


            Console.WriteLine("Seu nome é " + nome);
            Console.ReadLine();
            Console.WriteLine("Sua idade é " + minhaIdade);
            Console.ReadLine();
            Console.Write("Meu carro faz uma média de " + mediaCarro + "Km/L.");
            Console.ReadLine();
            Console.WriteLine("Na escola minhas notas eram todas " + notaEscola + "+");
            Console.ReadLine();

            if (verdade == true)
            {
                Console.WriteLine("É verdade esse bilete!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("É mentira dela!");
                Console.ReadLine();
            }


        }
    } /*Fim do programa*/
}
