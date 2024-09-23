using System;

Console.WriteLine("Por favor, insira seu nome e sobrenome:");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Insira sua data de nascimento (dd/MM/yyyy):");
string dataNascimentoInput = Console.ReadLine();

DateTime dataNascimento;

if (DateTime.TryParseExact(dataNascimentoInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
{
    int idade = CalcularIdade(dataNascimento);

    Console.WriteLine($"Olá, {nomeCompleto}! Sua idade é: {idade} anos.");
}
else
{
    Console.WriteLine("Data de nascimento inválida. Por favor, use o formato dd/MM/yyyy.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

int CalcularIdade(DateTime dataNascimento)
{
    DateTime dataAtual = DateTime.Now;
    int idade = dataAtual.Year - dataNascimento.Year;

    if (dataAtual < dataNascimento.AddYears(idade))
    {
        idade--;
    }

    return idade;
}
