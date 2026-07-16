namespace SistemaRendaCS{
    public class program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
        static void Menu()
        {
            Console.WriteLine(
                //Depois trocar menu para acessar meses individualmente (sendo uma lista de despesas e receitas)
                "Olá, seja bem vindo!\n1-Adicionar despesa\n2-Adicionar Receita\n3-Analisar Situação\n4-Deletar Despesa\n5-Deletar Receita\n6-Fechar menu");
                int menu = int.Parse(Console.ReadLine());
                // criar encapsulamento pra evitar erros de digitação,  ou deixar pra quando implementar interface gráfica
            switch (menu)
            {
                case 1: 
            }
        }
    }

}
