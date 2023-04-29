using ExercicioOperacoes;

Console.WriteLine("Olá, boas vindas ao Calculador!");
Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é igual a = "+operacoes.Soma.Calcular(10,10));
Console.WriteLine("O valor é igual a = " +operacoes.Subtracao.Calcular(30, 15));
Console.WriteLine("O valor é igual a = " + operacoes.Divisao.Calcular(657, 30));
Console.WriteLine("O valor é igual a = " + operacoes.Multiplicacao.Calcular(10, 10));

Console.ReadKey();