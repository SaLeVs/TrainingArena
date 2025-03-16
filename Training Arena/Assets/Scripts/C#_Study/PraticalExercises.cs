using UnityEngine;

public class PraticalExercises : MonoBehaviour
{
    // Todas as respostas que vem do console s�o strings, ent�o antes de verificarmos elas, precisamos passar para o tipo de vari�vel que queremos
    // Convert.ToInt32() converte uma string para um inteiro, dentro dos parenteses passamos a string que queremos converter Console.ReadLine()
    // essa fun��o readlLine() l� a linha que o usu�rio digitou no console
    // para verificarmos se o usu�rio digitou um n�mero, podemos usar a fun��o int.TryParse() que tenta converter uma string para um inteiro
    // Por passos a formula magica para criar um input bom no console �

    // 1 - passo criar um do while
    // 2 - colocar a primeira instru��o, normalmente o problema que queremos resolver
    // 3 - Salvar o que o usu�rio digitou em uma vari�vel
    // 4 - usar a fun��o int.TryParse() para verificar se o que o usu�rio digitou � um n�mero
    // se for, faz alguma coisa, se nao for s� continua o programa (esse alguma coisa � chamar uma fun��o que faz o que queremos)
    // 5 - fazer um outro do while para perguntar se o usu�rio quer continuar
    // salva a resposta dele em outra vari�vel
    // 6  - checa se a resposta � diferente de S ou N, se for, pede para ele digitar S ou N
    // 7 - faz o while, se a resposta for diferente de S ou N ele salva continuar na resposta e o loop acontece, se nao for diferente ele checa se for S, se for S ele repete todo o loop, se for N como n�o tem nenuhma instru��o ele sai do loop


    /*

        string continuar = "S";

        do {
          Console.WriteLine("Digite um n�mero para verificar se � par ou �mpar:");
          string input = Console.ReadLine();

          if (int.TryParse(input, out int number)) 
          {
            CalculateChange(number);
          } 
          else 
          {
            Console.WriteLine("Por favor, digite um n�mero v�lido.");
            continue;
          }

          string resposta;

          do 
          {
            Console.WriteLine("\nDeseja verificar outro n�mero? (Digite S para Sim ou N para N�o)");

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
