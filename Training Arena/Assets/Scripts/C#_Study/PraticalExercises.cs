using UnityEngine;

public class PraticalExercises : MonoBehaviour
{
    // Todas as respostas que vem do console sáo strings, então antes de verificarmos elas, precisamos passar para o tipo de variável que queremos
    // Convert.ToInt32() converte uma string para um inteiro, dentro dos parenteses passamos a string que queremos converter Console.ReadLine()
    // essa função readlLine() lê a linha que o usuário digitou no console
    // para verificarmos se o usuário digitou um número, podemos usar a função int.TryParse() que tenta converter uma string para um inteiro
    // Por passos a formula magica para criar um input bom no console é

    // 1 - passo criar um do while
    // 2 - colocar a primeira instrução, normalmente o problema que queremos resolver
    // 3 - Salvar o que o usuário digitou em uma variável
    // 4 - usar a função int.TryParse() para verificar se o que o usuário digitou é um número
    // se for, faz alguma coisa, se nao for só continua o programa (esse alguma coisa é chamar uma função que faz o que queremos)
    // 5 - fazer um outro do while para perguntar se o usuário quer continuar
    // salva a resposta dele em outra variável
    // 6  - checa se a resposta é diferente de S ou N, se for, pede para ele digitar S ou N
    // 7 - faz o while, se a resposta for diferente de S ou N ele salva continuar na resposta e o loop acontece, se nao for diferente ele checa se for S, se for S ele repete todo o loop, se for N como não tem nenuhma instrução ele sai do loop


    /*

        string continuar = "S";

        do {
          Console.WriteLine("Digite um número para verificar se é par ou ímpar:");
          string input = Console.ReadLine();

          if (int.TryParse(input, out int number)) 
          {
            CalculateChange(number);
          } 
          else 
          {
            Console.WriteLine("Por favor, digite um número válido.");
            continue;
          }

          string resposta;

          do 
          {
            Console.WriteLine("\nDeseja verificar outro número? (Digite S para Sim ou N para Não)");

            resposta = Console.ReadLine().ToUpper();

            if (resposta != "S" && resposta != "N") 
            {
              Console.WriteLine("Por favor, digite apenas S ou N.");
            }
          } 
          while (resposta != "S" && resposta != "N");
          {
            continuar = resposta;
          }
        } 
        while (continuar == "S");
        {

        }
      }

    */
}
