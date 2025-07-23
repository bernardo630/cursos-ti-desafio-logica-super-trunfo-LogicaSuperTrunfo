using System;

class CartaCidade
{
    public string Estado;
    public string Codigo;
    public string Nome;
    public int Populacao;
    public double Area;
    public double PIB;
    public int PontosTuristicos;

    public double DensidadePopulacional()
    {
        return Populacao / Area;
    }

    public void Exibir()
    {
        Console.WriteLine("\n--- Carta da Cidade ---");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"População: {Populacao}");
        Console.WriteLine($"Área: {Area}");
        Console.WriteLine($"PIB: {PIB}");
        Console.WriteLine($"Pontos Turísticos: {PontosTuristicos}");
        Console.WriteLine($"Densidade Populacional: {DensidadePopulacional():F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Cadastro da Carta 1:");
        CartaCidade carta1 = CadastrarCarta();

        Console.WriteLine("\nCadastro da Carta 2:");
        CartaCidade carta2 = CadastrarCarta();

        carta1.Exibir();
        carta2.Exibir();

        Console.WriteLine("\nEscolha o atributo para comparar:");
        Console.WriteLine("1 - População");
        Console.WriteLine("2 - Área");
        Console.WriteLine("3 - PIB");
        Console.WriteLine("4 - Pontos Turísticos");
        Console.WriteLine("5 - Densidade Populacional");

        Console.Write("Digite a opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine();
        CompararCartas(carta1, carta2, opcao);
    }

    static CartaCidade CadastrarCarta()
    {
        CartaCidade carta = new CartaCidade();

        Console.Write("Estado: ");
        carta.Estado = Console.ReadLine();

        Console.Write("Código da carta: ");
        carta.Codigo = Console.ReadLine();

        Console.Write("Nome da cidade: ");
        carta.Nome = Console.ReadLine();

        Console.Write("População: ");
        carta.Populacao = int.Parse(Console.ReadLine());

        Console.Write("Área: ");
        carta.Area = double.Parse(Console.ReadLine());

        Console.Write("PIB: ");
        carta.PIB = double.Parse(Console.ReadLine());

        Console.Write("Nº de pontos turísticos: ");
        carta.PontosTuristicos = int.Parse(Console.ReadLine());

        return carta;
    }

    static void CompararCartas(CartaCidade c1, CartaCidade c2, int opcao)
    {
        if (opcao == 1) // População
        {
            if (c1.Populacao > c2.Populacao)
                Console.WriteLine($"Vencedora: {c1.Nome} (maior população)");
            else if (c2.Populacao > c1.Populacao)
                Console.WriteLine($"Vencedora: {c2.Nome} (maior população)");
            else
                Console.WriteLine("Empate na população!");
        }
        else if (opcao == 2) // Área
        {
            if (c1.Area > c2.Area)
                Console.WriteLine($"Vencedora: {c1.Nome} (maior área)");
            else if (c2.Area > c1.Area)
                Console.WriteLine($"Vencedora: {c2.Nome} (maior área)");
            else
                Console.WriteLine("Empate na área!");
        }
        else if (opcao == 3) // PIB
        {
            if (c1.PIB > c2.PIB)
                Console.WriteLine($"Vencedora: {c1.Nome} (maior PIB)");
            else if (c2.PIB > c1.PIB)
                Console.WriteLine($"Vencedora: {c2.Nome} (maior PIB)");
            else
                Console.WriteLine("Empate no PIB!");
        }
        else if (opcao == 4) // Pontos turísticos
        {
            if (c1.PontosTuristicos > c2.PontosTuristicos)
                Console.WriteLine($"Vencedora: {c1.Nome} (mais pontos turísticos)");
            else if (c2.PontosTuristicos > c1.PontosTuristicos)
                Console.WriteLine($"Vencedora: {c2.Nome} (mais pontos turísticos)");
            else
                Console.WriteLine("Empate nos pontos turísticos!");
        }
        else if (opcao == 5) // Densidade populacional (MENOR vence)
        {
            double dens1 = c1.DensidadePopulacional();
            double dens2 = c2.DensidadePopulacional();

            if (dens1 < dens2)
                Console.WriteLine($"Vencedora: {c1.Nome} (menor densidade populacional)");
            else if (dens2 < dens1)
                Console.WriteLine($"Vencedora: {c2.Nome} (menor densidade populacional)");
            else
                Console.WriteLine("Empate na densidade populacional!");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}
