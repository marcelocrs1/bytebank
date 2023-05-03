using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return numero_agencia; }
            set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }

            }
        }


        private string nome_agencia;
        public string Nome_agencia
        {
            get { return nome_agencia; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome da agencia precisa ter mais que 3 caracteres");
                }
                else
                {
                    this.nome_agencia = value;
                }
            }
        }


        private string conta;
        public string Conta
        {
            get { return conta; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("A conta precisa ter no minimo 4 dígitos");
                }
                else
                {
                    this.conta = value; 
                }
            }
        }


        public Cliente Titular { get; set; }


        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = value;
                }
            }
        }


        private string moeda;
        public string Moeda
        {
            get { return moeda; }
            set
            {
                if (value.Length < 0)
                {
                    return;
                }
                else
                {
                    this.moeda = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + Titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Nome Agência :" + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

    }
}
