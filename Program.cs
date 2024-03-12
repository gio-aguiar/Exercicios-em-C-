//Exercícios: 
//1: Criar um método que te diga a data de hoje
//2. Verificar se hoje é um dia letivo


namespace Aula02Exemplos
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Digite o número referente a opção que você quer utilizar:");
            Console.WriteLine("1 - Calcular a quantidade de números em seu nome e dias vividos");
            Console.WriteLine("2- Verificar dias letivos");
            Console.WriteLine("3- Calcular sua nota média");
            Console.WriteLine("4- Calcular a tabuada");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    ConcatenarPalavras();
                    break;

                case 2:
                    VerificarAula();
                    break;

                case 3:
                    CalcularMedia();
                    break;

                case 4: 
                    CalcularTabuada();
                    break;
            }
        }


//Exercício 1:
        public static void ConcatenarPalavras()
        {

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:>MMMM} de {0:yyyy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho.ToUpper());
        }

//Exercício 2:
        public static void VerificarAula()
        {
            Console.WriteLine("Digite a data de hoje: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday) {
                Console.WriteLine("Hoje não é um dia letivo.");
            }

            else {
                Console.WriteLine("Hoje é um dia letivo!");
                Console.WriteLine("");
            }
        }

//Exercicio 3: Calcular media
        public static void CalcularMedia()
        {
            Console.WriteLine("Digite sua primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine ("Digite sua terceira nota");
            decimal nota3 = decimal.Parse(Console.ReadLine());

            decimal media = ( nota1 + nota2 + nota3 ) / 3;
            Console.WriteLine($"A média é {media}");
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Qual o divisor que você deseja calcular?");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while(contador <=10){

                string mensagem = string.Format("{0} x {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }
    }
}
