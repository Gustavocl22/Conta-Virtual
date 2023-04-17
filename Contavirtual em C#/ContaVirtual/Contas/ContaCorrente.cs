using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContaVirtual.ContaCorrente

{

    public class ContaCorrente
    {
        public string numero_agencia {get ; set;}
        
        public string Conta { get; set; }

        public double saldo { get; set; }

        public string  Titular {get; set; }

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

        

    }
}
