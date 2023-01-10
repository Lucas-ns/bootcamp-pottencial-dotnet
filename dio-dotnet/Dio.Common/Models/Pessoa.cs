using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    

        public int Idade 
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}