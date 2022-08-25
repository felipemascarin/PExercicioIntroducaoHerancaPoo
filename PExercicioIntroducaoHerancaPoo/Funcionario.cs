using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioIntroducaoHerancaPoo
{
    internal class Funcionario : Pessoa
    {
        //Atributos
        private string Pis;
        private float Salario;
        private string Setor;


        //Construtores:
        public Funcionario()
        {
        }

        public Funcionario(string nome, DateTime nascimento, string cpf, string pis, float salario, string setor)
            : base(nome, nascimento, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }

        //Getters:
        public string GetPis()
        {
            return Pis;
        }
        public float GetSalario()
        {
            return Salario;
        }
        public string GetSetor()
        {
            return Setor;
        }

        //Setters:
        public void SetPis(string pis)
        {
            Pis = pis;
        }
        public void SetSalario(float salario)
        {
            Salario = salario;
        }
        public void SetSetor(string setor)
        {
            Setor = setor;
        }

        //ToString:
        public override string ToString()
        {
            return base.ToString() + "\nPIS: " + GetPis() + "\nSalario: " + GetSalario() + "\nSetor: " + GetSetor();
        }

       



        }
}
