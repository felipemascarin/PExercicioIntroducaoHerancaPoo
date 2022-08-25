using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioIntroducaoHerancaPoo
{
    internal class Pessoa
    {

        //Atributos:
        private string Nome;
        private DateTime Nascimento;
        private string Cpf;



        //Construtores:
        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime nascimento, string cpf)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
        }



        //Getters:
        public string GetNome()
        {
            return Nome;
        }
        public DateTime GetNascimento()
        {
            return Nascimento;
        }
        public string GetCpf()
        {
            return Cpf;
        }


        //Setters:
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetNascimento(DateTime nascimento)
        {
            Nascimento = nascimento;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        //ToString:
        public override string ToString()
        {
            return "\nNome: " + GetNome() + "\nData de Nascimento: " + GetNascimento() + "\nCPF: " + GetCpf();
        }


    }
}
