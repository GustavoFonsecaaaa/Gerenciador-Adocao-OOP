internal class Program
{


    
    private static void Main(string[] args)
    {
        adotante[] cadastros = new adotante[2];

        for (int i = 0; i < cadastros.Length; i++)
        {
            cachorro cachorro = new cachorro();
            adotante adotante = new adotante();

            Console.WriteLine($"Informe o nome do {i + 1} adotante: ");
            adotante.nomePessoa = Console.ReadLine();

            Console.WriteLine($"Informe o nome do {i + 1} cachorro que vai está sendo adotado.");
            cachorro.nomeCachorro = Console.ReadLine();

            Console.WriteLine($"Informe a raça do cachorro: ");
            cachorro.raca = Console.ReadLine();

            Console.WriteLine($"Informe a idade do cachorro adotado:");
            cachorro.idade = int.Parse(Console.ReadLine());

            adotante.cachorroAdotado = cachorro;

            
            cadastros[i] = adotante;
        }
        Console.WriteLine("\n--- RELATÓRIO DE ADOÇÕES ---");

        foreach (adotante pessoa in cadastros)
        {
            Console.WriteLine($"O adotante {pessoa.nomePessoa} levou o(a) cachorro(a) {pessoa.cachorroAdotado.nomeCachorro}.");
            Console.WriteLine($"Raça: {pessoa.cachorroAdotado.raca} | Idade: {pessoa.cachorroAdotado.idade} anos.\n");
        }

        Console.ReadKey();
    }
}