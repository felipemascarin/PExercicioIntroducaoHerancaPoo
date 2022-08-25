using System;

namespace PExercicioIntroducaoHerancaPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CADASTRO DE ALUNO");
            Console.WriteLine("Informe a Quantidade de Alunos:");
            int qtd_alunos = int.Parse(Console.ReadLine());
            Aluno[] aluno = new Aluno[qtd_alunos];

            for (int i = 0; i < qtd_alunos; i++)
            {
                Console.WriteLine("\nCadastro do aluno " + (i + 1) + ": ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Nascimento (Formato dia/mes/ano): ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("RA: ");
                int ra = int.Parse(Console.ReadLine());
                Console.WriteLine("Data de Matricula: ");
                DateTime datamatricula = DateTime.Parse(Console.ReadLine());
                aluno[i] = new Aluno(nome, nascimento, cpf, ra, datamatricula);
            }



            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIO");
            Console.WriteLine("Informe a Quantidade de Funcionários:");
            int qtd_funcionarios = int.Parse(Console.ReadLine());
            Funcionario[] funcionario = new Funcionario[qtd_funcionarios];

            for (int i = 0; i < qtd_funcionarios; i++)
            {
                Console.WriteLine("\nCadastro do funcionário " + (i + 1) + ": ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Nascimento (Formato dia/mes/ano): ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("PIS: ");
                string pis = Console.ReadLine();
                Console.WriteLine("Valor do Salário: ");
                float salario = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Setor: ");
                string setor = Console.ReadLine();
                funcionario[i] = new Funcionario(nome, nascimento, cpf, pis, salario, setor);
            }

            for (int i = 0; i < qtd_alunos; i++)
            {
                Console.WriteLine(aluno[i]);
            }
            for (int i = 0; i < qtd_funcionarios; i++)
            {
                Console.WriteLine(funcionario[i]);
            }
        }
    }
}
