using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        public string nome;
        public string familia;
        public string cor;
        public string corAsa;
        public double tamanhoAsa;
        public bool asaQuebrada;
        public bool mulher;
        public bool fazBarulho;
        public string elemento;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }
                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }
                nome = value;
            }


        }
        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }
                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }
                familia = value;
            }
        }
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor deve ser preenchido");
                }
                if (value.Count() == 1)
                {
                    throw new Exception("Cor deve conter no mínimo 2 caracteres");
                }
                cor = value;
            }
        }
        public string CorAsa
        {
            get
            {
                return corAsa;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor da asa deve ser preenchido");
                }
                if (value.Count() == 1)
                {
                    throw new Exception("Cor da asa deve conter no mínimo 2 caracteres");
                }
                corAsa = value;
            }

        }
        public double TamanhoAsa
        {
            get
            {
                return tamanhoAsa;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("tamanho não pode ser menor que 0");
                }
                if (value == null)
                {
                    throw new Exception("Tamanho da asa deve ser preenchido");
                }
                tamanhoAsa = value;
            }
        }
        public bool AsaQuebrada
        {
            get
            {
                return asaQuebrada;
            }

        }

    }
}
