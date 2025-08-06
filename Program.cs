try
{
    Console.WriteLine("Bem-vindo ao validador de CPF!");
    Thread.Sleep(1200);
    Console.WriteLine("Insira o CPF a ser validado:");
    string cpf = Console.ReadLine();

    cpf = cpf.Replace(".", "").Replace("-", "");

    bool cpfValido = true; 

    foreach (char x in cpf)
    {
        if (!char.IsDigit(x) || (cpf.Length != 11))
        {
            cpfValido = false;
            Console.WriteLine("Formato inválido! um CPF deve conter apenas números e ter 11 dígitos.");
            break;
        }

    }

    string baseCPF = cpf.Substring(0, 9);
    string digitosVerificadores = cpf.Substring(9,2);

    int j = 10;
    int soma = 0;

    for (int i = 0; i < baseCPF.Length; i++) //primeiro digito
    {
        char c = baseCPF[i];
        int digito = int.Parse(c.ToString());

        int calc = digito * j;
        j--;

        soma += calc;
    }

    int primeiroDigito = soma % 11;

    if (primeiroDigito < 2)
    {
        primeiroDigito = 0;
    }
    else
    {
        primeiroDigito = 11 - primeiroDigito;
    }

    string baseCPFComPrimeiro = baseCPF + primeiroDigito.ToString();

    j = 11;
    soma = 0;

    for (int i = 0; i < baseCPFComPrimeiro.Length; i++) //segundo digito
    {
        char c = baseCPFComPrimeiro[i];
        int digito = int.Parse(c.ToString());

        int calc = digito * j;
        j--;

        soma += calc;
    }

    int segundoDigito = soma % 11;

    if (segundoDigito < 2)
    {
        segundoDigito = 0;
    }
    else
    {
        segundoDigito = 11 - segundoDigito;
    }

    if (digitosVerificadores == primeiroDigito.ToString() + segundoDigito.ToString())
    {
        Console.WriteLine("CPF válido!");
    }
    else
    {
        Console.WriteLine("CPF inválido!");
    }

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine("\nOcorreu um erro durante a execução do programa:\n" + ex.Message);
}

