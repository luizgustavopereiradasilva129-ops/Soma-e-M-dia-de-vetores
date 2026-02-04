using System;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;


int N;
Console.WriteLine("Quantas Notas serão digitadas ?");
N = int.Parse(Console.ReadLine());

double[] notas = new double [N];

for (int i = 0; i < N; i++) 
{
    Console.WriteLine("Digite uma nota ");
    notas[i] = double.Parse(Console.ReadLine(), CI);

}
Console.WriteLine();
Console.WriteLine("Notas digitadas: ");
for (int i = 0; i < N; i++) {
    Console.WriteLine(notas[i].ToString("F1", CI));
}
double soma = 0.0;
for (int i = 0; i < N; i++) {
    soma += notas[i];
}

double media = soma / N;
Console.WriteLine("A soma dos valores: " + soma.ToString("F2", CI));
Console.WriteLine("Média: " + media.ToString("F2", CI));
