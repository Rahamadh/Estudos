using System;

class MenorNumeroImparMatriz2x2 {

  static void Main(string[] args) {
    // Declaração da matriz 2x2
    int[,] matriz = new int[2, 2];

    // Entrada dos valores da matriz
    Console.WriteLine("Preencha a matriz 2x2:");
    for (int i = 0; i < 2; i++) {
      for (int j = 0; j < 2; j++) {
        Console.Write($"Digite o elemento [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
      }
    }

    // Variável para armazenar o menor número ímpar
    int menorImpar = int.MaxValue;

    // Busca pelo menor número ímpar na matriz
    for (int i = 0; i < 2; i++) {
      for (int j = 0; j < 2; j++) {
        if (matriz[i, j] % 2 != 0 && matriz[i, j] < menorImpar) {
          menorImpar = matriz[i, j];
        }
      }
    }

    // Verificação se existe um número ímpar na matriz
    if (menorImpar == int.MaxValue) {
      Console.WriteLine("Não há números ímpares na matriz.");
    } else {
      Console.WriteLine($"O menor número ímpar na matriz é {menorImpar}.");
    }
  }
}
