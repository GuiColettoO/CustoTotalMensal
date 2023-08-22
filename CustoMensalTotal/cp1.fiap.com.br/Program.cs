using cp1.fiap.com.br.Model;

IList<FuncionarioCLT> listaFuncionarioCLT = new List<FuncionarioCLT>();
IList<FuncionarioPJ> listaFuncionarioPJ = new List<FuncionarioPJ>();

FuncionarioCLT funcioanrio1 = new FuncionarioCLT(1, "Augusto", Genero.Masculino, 8000.30m, true);
FuncionarioCLT funcioanrio2 = new FuncionarioCLT(2, "Leandro", Genero.Masculino, 3000, false);

listaFuncionarioCLT.Add(funcioanrio1);
listaFuncionarioCLT.Add(funcioanrio2);

FuncionarioPJ funcioanrio3 = new FuncionarioPJ(3, "João", Genero.Masculino, 45.68m, 130, "123.123.123/0001-54");
FuncionarioPJ funcioanrio4 = new FuncionarioPJ(4, "Paulo", Genero.Masculino, 64.28m, 200, "321.321.321/0001-34");

listaFuncionarioPJ.Add(funcioanrio3);
listaFuncionarioPJ.Add(funcioanrio4);

foreach (var c in listaFuncionarioPJ)
    {
        Console.WriteLine($"Nome: {c.Nome}, Genero: {c.Genero}, Custo Hora: R{c.ValorHora.ToString("C")}, Hora Contratada: {c.ValorHoraContratada}, CNPJ: {c.CNPJ}");
    }

foreach (var c in listaFuncionarioCLT)
    {
        Console.WriteLine($"Nome: {c.Nome}, Genero: {c.Genero}, Salario: R{c.Salario.ToString("C")}, Cargo de Confiança: {c.CargoConfianca}");
    }

decimal Total = 0;

foreach (var c in listaFuncionarioPJ)
    {
    Total += c.CalcularCustoMensal();
    }

foreach (var c in listaFuncionarioCLT)
    {
    Total += c.CalcularCustoMensal();
    }


Console.WriteLine($"Total: R{Total.ToString("C")}");

decimal NovoSalario = 0;
foreach (var c in listaFuncionarioCLT)
{
    if(c.Codigo == 01)
    {
       NovoSalario = c.Salario + (c.Salario * 0.26m);
    }
}

Console.WriteLine($"Novo Salario: R{NovoSalario.ToString("C")}");

foreach (var c in listaFuncionarioPJ)
{
    if (c.Codigo == 01)
    {
        c.ValorHora = 56.81m;
        Console.WriteLine($"Novo Salario Hora: R{c.ValorHora.ToString("C")}");
    }
}


int registro = int.Parse(Console.ReadLine());
FuncionarioCLT? pesquisaCLT = listaFuncionarioCLT.FirstOrDefault(funcionario => funcionario.Codigo == registro);
    if( pesquisaCLT != null)
    {
    Console.WriteLine($"Nome: {pesquisaCLT.Nome}, Genero: {pesquisaCLT.Genero}, Salario: R{pesquisaCLT.Salario.ToString("C")}, Cargo de Confiança: {pesquisaCLT.CargoConfianca}" +
        $"\nCusto Total Mensal: R{pesquisaCLT.CalcularCustoMensal().ToString("C")}");
    }
    else
    {
    FuncionarioPJ? pesquisaPJ = listaFuncionarioPJ.FirstOrDefault(funcionario => funcionario.Codigo == registro);
        if(pesquisaPJ != null )
        {
            Console.WriteLine($"Nome: {pesquisaPJ.Nome}, Genero: {pesquisaPJ.Genero}, Custo Hora: R{pesquisaPJ.ValorHora.ToString("C")}, Hora Contratada: {pesquisaPJ.ValorHoraContratada}, CNPJ: {pesquisaPJ.CNPJ}" +
                $"\nCusto Total Mensal: R{pesquisaPJ.CalcularCustoMensal().ToString("C")}");
    }
        else
        {
            throw new Exception("Código não encontrado!");
        }
    }













