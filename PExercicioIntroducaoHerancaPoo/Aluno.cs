using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioIntroducaoHerancaPoo
{
    internal class Aluno : Pessoa
    {
        //Atributos:
        int Ra;
        DateTime DataMatricula;



        //Construtores:
        public Aluno()
        {
        }

        public Aluno(string nome, DateTime nascimento, string cpf, int ra, DateTime datamatricula)
            : base(nome, nascimento, cpf)
        {
            Ra = ra;
            DataMatricula = datamatricula;
        }

        //Getters:
        public int GetRa()
        {
            return Ra;
        }
        public DateTime GetDataMatricula()
        {
            return DataMatricula;
        }


        //Setters:
        public void SetRa(int ra)
        {
            Ra = ra;
        }
        public void SetDataMatricula(DateTime datamatricula)
        {
            DataMatricula = datamatricula;
        }

        //ToString:
        public override String ToString()
        {
            return base.ToString() + "\nRA: " + GetRa() + "\nData de Matrícula: " + GetDataMatricula();
        }

       
     



    }
}
